using FluentValidation;

namespace Business.Commands.CreateBMIResult
{
    public class CreateBmiResultValidator : AbstractValidator<CreateBmiResultCommand>
    {
        public CreateBmiResultValidator()
        {
        }
    }
}