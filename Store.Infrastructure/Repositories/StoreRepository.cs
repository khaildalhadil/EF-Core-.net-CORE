

using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities;
using Store.Domain.store;


namespace Store.Infrastructure.Repositories;

internal class StoreRepository(StoreDbContext storeDb) : IStoreRepository
{
    public async Task<IEnumerable<StoreModel>> GetAll()
    {
        return await storeDb.Stores.ToListAsync();
    }

    public async Task<StoreModel> GetByIdAsync(int id)
    {
        return await storeDb.FindAsync<StoreModel>(id);
    }
}
