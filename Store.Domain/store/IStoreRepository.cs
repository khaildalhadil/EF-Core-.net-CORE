

using Store.Domain.Entities;

namespace Store.Domain.store;
public interface IStoreRepository
{
    public Task<IEnumerable<StoreModel>> GetAll();
    public Task<StoreModel> GetByIdAsync(int id);
}
