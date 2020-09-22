using System.Threading;
using System.Threading.Tasks;
using Contracts.Responses;
using Infrastructure.Result.Results;
using MediatR;

namespace Business.Commands.CreateBMIResult
{
    public class CreateBmiResultHandler : IRequestHandler<CreateBmiResultCommand, IResult<BmiResultResource>>
    {
        public Task<IResult<BmiResultResource>> Handle(
            CreateBmiResultCommand request, 
            CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}