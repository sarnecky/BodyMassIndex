using Contracts.Requests;
using Infrastructure.MediatR.Interfaces;
using Infrastructure.Result;

namespace Business.Commands.CreateBMIResult
{
    public class CreateBmiResultCommand : ICommand<Unit>
    {
        public readonly string FirstName;
        public readonly string LastName;
        public readonly int Height;
        public readonly int Weight;
        public CreateBmiResultCommand(BmiResultDto bmiResultDto)
        {
            FirstName = bmiResultDto.FirstName;
            LastName = bmiResultDto.LastName;
            Height = bmiResultDto.Height;
            Weight = bmiResultDto.Weight;
        }
    }
}