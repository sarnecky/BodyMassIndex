using Contracts.Requests;
using Contracts.Responses;
using Infrastructure.MediatR.Interfaces;

namespace Business.Commands.CreateBMIResult
{
    public class CreateBmiResultCommand : ICommand<BmiResultResource>
    {
        public readonly BmiResultDto BmiResultDto;
        public CreateBmiResultCommand(BmiResultDto bmiResultDto)
        {
            BmiResultDto = bmiResultDto;
        }
    }
}