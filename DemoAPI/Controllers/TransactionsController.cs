using DemoAPI.Application.Interfaces;
using DemoAPI.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionsService _transactionsService;

        public TransactionsController(ITransactionsService transactionsService)
        {
            _transactionsService = transactionsService;
        }

        [HttpGet]
        public TransactionsViewModel GetTransactions()
        {
            return _transactionsService.GetTransactions();
        }
    }
}
