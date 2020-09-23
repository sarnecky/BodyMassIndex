using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Database.SQL
{
    public class BodyMassIndexContextFactory : IDesignTimeDbContextFactory<BodyMassIndexContext>
    {
        private readonly string _connectionString;
        public BodyMassIndexContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }
        
        public BodyMassIndexContext CreateDbContext(string[] args)
        {
            var optionsBuilder =  new DbContextOptionsBuilder<BodyMassIndexContext>()
                .UseSqlServer(_connectionString);

            return new BodyMassIndexContext(optionsBuilder.Options);
        }
    }
}