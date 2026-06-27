using Store.Application.Extension;
using Store.Infrastructure.Extensions;
using Store.Infrastructure.Seeders;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddApplicationServices();

// Add services to the container.

var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.MapControllers();
var scope = app.Services.CreateScope();
var seeds = scope.ServiceProvider.GetRequiredService<IStoreSeeders>();
await seeds.Seed();

app.Run();

