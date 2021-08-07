using DemoAPI.Application.ViewModels;

namespace DemoAPI.Application.Interfaces
{
    public interface ITransactionsService
    {
        TransactionsViewModel GetTransactions();
    }
}
