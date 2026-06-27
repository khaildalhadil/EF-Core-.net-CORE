

using Store.Domain.Entities;
using Store.Domain.store;

namespace Store.Application.service;

public class StoreService(IStoreRepository storeRepository) : IStoreService
{
    private readonly IStoreRepository _storeRepository = storeRepository;

    public async Task<IEnumerable<StoreModel>> GetAllAsync()
    {
        return await _storeRepository.GetAll();
    }

    public async Task<StoreModel> GetByIdAsync(int id)
    {
        StoreModel store = await _storeRepository.GetByIdAsync(id);
        return store;
    }

    //public async Task<StoreModel>


}

