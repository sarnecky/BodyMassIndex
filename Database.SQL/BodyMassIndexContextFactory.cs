using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Database.SQL
{
    public class BodyMassIndexContextFactory : IDesignTimeDbContextFactory<BodyMassIndexContext>
    {
        private readonly string _connectionString;
        public BodyMassIndexContextFactory(string connectionString)
            : base()
        {
            _connectionString = connectionString;
        }
        public BodyMassIndexContextFactory() {}
        public BodyMassIndexContext CreateDbContext(string[] args)
        {
            var optionsBuilder =  new DbContextOptionsBuilder<BodyMassIndexContext>()
                .UseSqlServer("Data Source=localhost,50002;MultipleActiveResultSets=True;Integrated Security=False;User=sa;Password=12345678Aa.;Initial Catalog=");

            return new BodyMassIndexContext(optionsBuilder.Options);
        }
    }
}