using Database.SQL.Entities;
using Database.SQL.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Database.SQL
{
    public class BodyMassIndexContext : DbContext
    {
        public DbSet<BmiResult> BmiResults { get; set; }
        public BodyMassIndexContext(DbContextOptions options) 
            : base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BmiResultConfiguration());
        }
    }
}