using DemoAPI.Application.Interfaces;
using DemoAPI.Application.ViewModels;
using DemoAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace DemoAPI.Application.Services
{
    public class TransactionsService : ITransactionsService
    {
        public readonly ITransactionsRepository _transactionsRepository;

        public TransactionsService(ITransactionsRepository transactionsRepository)
        {
            _transactionsRepository = transactionsRepository;
        }

        public IEnumerable<TransactionsViewModel> GetTransactions()
        {
            return TransactionsViewModel.FromEntityEnumerable(_transactionsRepository.GetAll());
        }
    }
}
