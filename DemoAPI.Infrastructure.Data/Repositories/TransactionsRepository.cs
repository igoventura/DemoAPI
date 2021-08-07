using DemoAPI.Domain.Entities;
using DemoAPI.Domain.Interfaces;
using DemoAPI.Infrastructure.Data.Context;
using System.Collections.Generic;

namespace DemoAPI.Infrastructure.Data.Repositories
{
    public class TransactionsRepository : ITransactionsRepository
    {
        private readonly FinancesDbContext _context;

        public TransactionsRepository(FinancesDbContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Transactions> GetTransactions()
        {
            return _context.Transactions;
        }
    }
}
