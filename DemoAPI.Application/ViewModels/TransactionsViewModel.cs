using DemoAPI.Application.ViewModels.Base;
using DemoAPI.Domain.Entities;

namespace DemoAPI.Application.ViewModels
{
    public class TransactionsViewModel : ViewModel<Transactions, TransactionsViewModel>
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
