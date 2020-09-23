using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Database.SQL.Repository
{
    public class ReadRepository<TEntity> : IReadRepository<TEntity>
        where TEntity : class
    {
        private readonly IQueryable<TEntity> _query;
        
        public ReadRepository(DbContext context)
        {
            _query = context.Set<TEntity>().AsQueryable();
        }

        public async Task<IReadOnlyCollection<TEntity>> GetAsync() =>
            await _query.Select(i => i).AsNoTracking().ToListAsync();
    }
}