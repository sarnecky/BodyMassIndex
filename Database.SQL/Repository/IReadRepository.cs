using System.Collections.Generic;
using System.Threading.Tasks;

namespace Database.SQL.Repository
{
    public interface IReadRepository<TEntity>
        where TEntity : class
    {
        Task<IReadOnlyCollection<TEntity>> GetAsync();
    }
}