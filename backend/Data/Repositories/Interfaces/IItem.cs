using backend.Data.Entities;

namespace backend.Data.Repositories.Interfaces;

public interface IItemRepository
{
    public Task<IEnumerable<Item>> GetAllItemsByShelfIdAsync(Guid shelfId);
    public Task<Item> GetItemByIdAsync(Guid id);
    public Task<Item> CreateItemAsync(Item item);
    public Task<bool> UpdateItemAsync(Item item);
    public Task<bool> DeleteItemAsync(Guid id);
}