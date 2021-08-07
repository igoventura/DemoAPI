using DemoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoAPI.Infrastructure.Data.Context
{
    public class FinancesDbContext : DbContext
    {
        public FinancesDbContext(DbContextOptions options) : base(options) {}

        public DbSet<Transactions> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transactions>()
                .Property(entity => entity.Price)
                    .HasPrecision(18, 2);

            base.OnModelCreating(modelBuilder);
        }
    }
}
