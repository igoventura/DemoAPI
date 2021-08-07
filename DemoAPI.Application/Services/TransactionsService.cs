using DemoAPI.Application.Interfaces;
using DemoAPI.Application.ViewModels;
using DemoAPI.Domain.Interfaces;
using System;

namespace DemoAPI.Application.Services
{
    public class TransactionsService : ITransactionsService
    {
        public readonly ITransactionsRepository _transactionsRepository;

        public TransactionsService(ITransactionsRepository transactionsRepository)
        {
            _transactionsRepository = transactionsRepository;
        }

        public TransactionsViewModel GetTransactions()
        {
            return new TransactionsViewModel
            {
                Transactions = _transactionsRepository.GetTransactions()
            };
        }
    }
}
