using DemoAPI.Domain.Entities;
using System.Collections.Generic;

namespace DemoAPI.Application.ViewModels
{
    public class TransactionsViewModel
    {
        public IEnumerable<Transactions> Transactions { get; set; }
    }
}
