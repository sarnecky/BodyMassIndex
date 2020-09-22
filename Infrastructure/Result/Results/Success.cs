namespace Infrastructure.Result.Results
{
    public class Success<T> : IResult<T>
    {
        public T Payload { get; }

        public Success(T payload)
        {
            Payload = payload;
        }
    }
}