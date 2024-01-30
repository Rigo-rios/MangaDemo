using MangaHut.Models.Models.Stores;

namespace MangaHut.Services.MangaServices.Contracts
{
    public interface IStoreService
    {
        Task<bool> AddStore(StoreCreate model);
        Task<bool> AddStore_Location(Store_Location_Create model);
        Task<StoreDetail> GetStore(int id);
        Task<bool>  EditStore(StoreEdit model);
        Task<List<StoreListItem>> GetStores();

    }
}