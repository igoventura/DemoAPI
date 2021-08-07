using DemoAPI.Application.Interfaces;
using DemoAPI.Application.Services.Base;
using DemoAPI.Application.ViewModels;
using DemoAPI.Domain.Entities;
using DemoAPI.Domain.Interfaces;

namespace DemoAPI.Application.Services
{
    public class TransactionsService : Service<Transactions, TransactionsViewModel>, ITransactionsService
    {
        public readonly ITransactionsRepository _transactionsRepository;

        public TransactionsService(ITransactionsRepository transactionsRepository) : base(transactionsRepository)
        {
            _transactionsRepository = transactionsRepository;
        }
    }
}
