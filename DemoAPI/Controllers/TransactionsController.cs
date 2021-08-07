using DemoAPI.Application.Interfaces;
using DemoAPI.Application.ViewModels;
using DemoAPI.Controllers.Base;
using DemoAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : BaseController<Transactions, TransactionsViewModel>
    {
        public TransactionsController(ITransactionsService transactionsService) : base(transactionsService) { }
    }
}
