using DemoAPI.Application.ViewModels;
using System.Collections.Generic;

namespace DemoAPI.Application.Interfaces
{
    public interface ITransactionsService
    {
        IEnumerable<TransactionsViewModel> GetTransactions();
    }
}
