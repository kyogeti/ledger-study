using System.Reflection;
using LedgerStudy.Infra.Context;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LedgerStudy.Application.Extensions
{
    public static class LedgerServicesConfiguration
    {
        public static void AddLedgerServices(this IServiceCollection services)
        {
            services.AddTransient<ILedgerContext, LedgerContext>();
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }

    }
}