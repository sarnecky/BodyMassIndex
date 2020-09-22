using FluentValidation;

namespace Infrastructure.Exceptions
{
    public class BadRequestException : ValidationException
    {
        public BadRequestException(string message) : base(message)
        {
        }
    }
}