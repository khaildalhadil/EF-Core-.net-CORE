using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Store.Application.service;
using Store.Domain.store;
using Store.Infrastructure.Repositories;
using Store.Infrastructure.Seeders;

namespace Store.Infrastructure.Extensions;
public static class ServiceCollectionExtensions 
{
    // IServiceCollection come from Service Registration
    // this to make it an extension method and accessible from builder.Services.AddInfrastructureServices();
    public static void AddInfrastructureServices(this IServiceCollection service, IConfiguration configuration)
    {
        service.AddDbContext<StoreDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("SotreDb")));

        service.AddScoped<IStoreSeeders, StoreSeeders>();
        service.AddScoped<IStoreRepository, StoreRepository>();
    }
}
