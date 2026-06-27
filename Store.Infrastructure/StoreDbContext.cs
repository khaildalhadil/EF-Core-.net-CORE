using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities;

namespace Store.Infrastructure;

internal class StoreDbContext(DbContextOptions<StoreDbContext> options): DbContext(options)
{
    internal DbSet<StoreModel> Stores { get; set; }
    internal DbSet<Item> Items { get; set; }

    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<StoreModel>()
            .OwnsOne(r => r.Address);

        modelBuilder.Entity<StoreModel>()
            .HasMany(r => r.Items)
            .WithOne()
            .HasForeignKey("StoreId");
    }
}
