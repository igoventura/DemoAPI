using DemoAPI.Application.Interfaces;
using DemoAPI.Application.Services;
using DemoAPI.Domain.Interfaces;
using DemoAPI.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DemoAPI.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ITransactionsService, TransactionsService>();
            services.AddScoped<ITransactionsRepository, TransactionsRepository>();
        }
    }
}
