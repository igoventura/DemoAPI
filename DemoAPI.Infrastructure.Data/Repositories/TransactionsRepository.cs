using DemoAPI.Domain.Entities;
using DemoAPI.Domain.Interfaces;
using DemoAPI.Infrastructure.Data.Context;
using DemoAPI.Infrastructure.Data.Repositories.Base;

namespace DemoAPI.Infrastructure.Data.Repositories
{
    public class TransactionsRepository : Repository<Transactions>, ITransactionsRepository
    {
        public TransactionsRepository(FinancesDbContext context) : base(context) { }
    }
}
