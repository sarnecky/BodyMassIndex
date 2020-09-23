using System;
using System.Threading;
using System.Threading.Tasks;
using Contracts.Responses;
using Infrastructure.Result;
using Infrastructure.Result.Results;
using MediatR;
using Unit = Infrastructure.Result.Unit;

namespace Business.Commands.CreateBMIResult
{
    public class CreateBmiResultHandler : IRequestHandler<CreateBmiResultCommand, IResult<Unit>>
    {
        public Task<IResult<Unit>> Handle(
            CreateBmiResultCommand request, 
            CancellationToken cancellationToken)
        {
            var bmi = Math.Round(
                (double)request.Weight / (request.Height * request.Height),
                MidpointRounding.ToEven);

            return new Unit().ToSuccessAsync();
        }
    }
}