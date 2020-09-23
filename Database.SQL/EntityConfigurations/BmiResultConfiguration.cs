using Database.SQL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.SQL.EntityConfigurations
{
    public class BmiResultConfiguration
        : IEntityTypeConfiguration<BmiResult>
    {
        public void Configure(EntityTypeBuilder<BmiResult> builder)
        {
            builder
                .HasKey(i => i.Id);

            builder
                .Property(i => i.Height)
                .IsRequired();
            
            builder
                .Property(i => i.Weight)
                .IsRequired();
            
            builder
                .Property(i => i.FirstName)
                .HasMaxLength(100)
                .IsRequired();
            
            builder
                .Property(i => i.LastName)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .HasIndex(i => new {i.FirstName, i.LastName}).IsUnique();
            
            builder
                .Property(i => i.Bmi)
                .IsRequired();
        }
    }
}