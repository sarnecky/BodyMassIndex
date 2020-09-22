using Infrastructure.Result.Results;
using MediatR;

namespace Infrastructure.MediatR.Interfaces
{
    public interface ICommand<T> : IRequest<IResult<T>>
    {
        
    }
}