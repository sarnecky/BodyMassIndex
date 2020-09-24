using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Database.SQL.Repository
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        private readonly DbContext _context;
        
        public Repository(DbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TEntity entity) => 
            await _context.Set<TEntity>().AddAsync(entity);
        public async Task SaveAsync() =>
            await _context.SaveChangesAsync();
    }
}