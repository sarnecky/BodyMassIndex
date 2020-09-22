using Infrastructure.Result.Results;
using MediatR;

namespace Infrastructure.MediatR.Interfaces
{
    public interface IQuery<T> : IRequest<IResult<T>>
    {
        
    }
}