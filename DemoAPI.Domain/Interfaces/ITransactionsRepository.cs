using DemoAPI.Domain.Entities;
using System.Collections.Generic;

namespace DemoAPI.Domain.Interfaces
{
    public interface ITransactionsRepository
    {
        IEnumerable<Transactions> GetTransactions();
    }
}
