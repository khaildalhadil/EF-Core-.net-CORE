
using Microsoft.Extensions.DependencyInjection;
using Store.Application.service;

namespace Store.Application.Extension;

public static class ServiceCollectionExtensions
{
    public static void AddApplicationServices(this IServiceCollection service)
    {
        service.AddScoped<IStoreService, StoreService>();
    }
}
