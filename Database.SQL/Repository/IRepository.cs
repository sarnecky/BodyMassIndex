using System.Threading.Tasks;

namespace Database.SQL.Repository
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        Task AddAsync(TEntity entity);
    }
}