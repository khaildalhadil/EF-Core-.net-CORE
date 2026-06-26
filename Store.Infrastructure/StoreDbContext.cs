using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities;

namespace Stores.Infrastructure;

internal class StoreDbContext: DbContext
{
    internal DbSet<StoreModel> Stores { get; set; }
    internal DbSet<Item> Items { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseSqlServer("Server=DESKTOP-0S77INR\\SQLEXPRESS;Database=Store;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;");
    }

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
