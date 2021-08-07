using DemoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoAPI.Infrastructure.Data.Context
{
    public class FinancesDbContext : DbContext
    {
        public FinancesDbContext(DbContextOptions options) : base(options) {}

        public DbSet<Transactions> Transactions { get; set; }
    }
}
