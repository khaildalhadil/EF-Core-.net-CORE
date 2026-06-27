using Store.Domain.Entities;

namespace Store.Application.service
{
    public interface IStoreService
    {
        Task<IEnumerable<StoreModel>> GetAllAsync();
        Task<StoreModel> GetByIdAsync(int id);


    }
}