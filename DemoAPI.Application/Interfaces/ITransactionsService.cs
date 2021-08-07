using DemoAPI.Application.Interfaces.Base;
using DemoAPI.Application.ViewModels;
using DemoAPI.Domain.Entities;

namespace DemoAPI.Application.Interfaces
{
    public interface ITransactionsService : IService<Transactions, TransactionsViewModel>
    {
    }
}
