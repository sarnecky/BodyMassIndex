using System.Threading.Tasks;
using Infrastructure.Result.Results;

namespace Infrastructure.Result
{
    public static class ResultExtensions
    {
        public static async Task<IResult<T>> ToSuccessAsync<T>(
            this T payload)
            where T : class
            => await Task.FromResult(new Success<T>(payload));
    }
}