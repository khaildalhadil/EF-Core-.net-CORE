

using Store.Domain.Entities;


namespace Store.Infrastructure.Seeders;

internal class StoreSeeders(StoreDbContext context) : IStoreSeeders
{
    public async Task Seed()
    {
        if (await context.Database.CanConnectAsync())
        {
            if (!context.Stores.Any())
            {
                var stores = GetStores();
                context.Stores.AddRange(stores);
                await context.SaveChangesAsync();
            }
        }
    }

    private IEnumerable<StoreModel> GetStores()
    {
        List<StoreModel> stores = new()
        {
            new StoreModel
            {
                
                Name = "Tech Store",
                Description = "Electronics and computer accessories store",
                Category = "Electronics",
                HasDevlivery = true,
                ContactEmail = "tech@store.com",
                ContactNumber = "91234567",

                Address = new Address
                {
                    City = "Muscat",
                    Street = "Al Khuwair",
                    PostalCode = "112"
                },

                Items = new List<Item>
                {
                    new Item
                    {
                        Name = "Laptop",
                        Description = "HP Laptop i7",
                        Price = 450.50m,
                        StoreId = 1
                    },
                    new Item
                    {
                        Name = "Mouse",
                        Description = "Wireless Mouse",
                        Price = 15.99m,
                        StoreId = 1
                    }
                }
            },

            new StoreModel
            {
                Name = "Coffee House",
                Description = "Specialty coffee shop",
                Category = "Food",
                HasDevlivery = false,
                ContactEmail = "coffee@store.com",
                ContactNumber = "99887766",

                Address = new Address
                {
                    City = "Sohar",
                    Street = "Al Hambar",
                    PostalCode = "311"
                },

                Items = new List<Item>
                {
                    new Item
                    {
                        Name = "Latte",
                        Description = "Hot coffee drink",
                        Price = 2.500m,
                        StoreId = 2
                    },
                    new Item
                    {
                        Name = "Cake",
                        Description = "Chocolate cake",
                        Price = 1.800m,
                        StoreId = 2
                    }
                }
            }
        };
        return stores;
    }
}
