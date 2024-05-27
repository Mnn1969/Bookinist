using Bookinist.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Bookinist.Services
{
    static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<ISalesService, SalesService>()
            .AddTransient<IDataService, DataService>()
            .AddTransient<IUserDialog, UserDialog>();
    }
}
