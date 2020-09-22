using Infrastructure.Result.Error;

namespace Infrastructure.Result.Results
{
    public class Failure<T> : IResult<T>
    {
        public readonly IError Error;

        public Failure(IError error)
        {
            Error = error;
        }
    }
}