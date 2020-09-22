using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using Infrastructure.Exceptions;
using MediatR;

namespace Infrastructure.MediatR
{
    public class CommandValidatorBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly IValidator<TRequest> _validator;

        public CommandValidatorBehavior(IValidator<TRequest> validator)
        {
            _validator = validator;
        }

        public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            var result = _validator.Validate(request);
            return !result.IsValid
                ? result.Errors switch
                {
                    var errors when errors.All(e => e.ErrorCode == "400") =>
                        throw new BadRequestException(string
                            .Join(',', errors.Select(i => i.ErrorMessage))),
                    _ => throw new Exception("Unknown Error")
                }
                : next();
        }
    }
}