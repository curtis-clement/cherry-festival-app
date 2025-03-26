using backend.Data.Entities;

namespace backend.Data.Repositories.Interfaces;

public interface IShelfRepository
{
    public Task<IEnumerable<Shelf>> GetAllSectionShelvesAsync(Guid sectionId);
    public Task<Shelf> GetSectionShelfByIdAsync(Guid id);
    public Task<Shelf> CreateSectionShelfAsync(Shelf shelf);
    public Task<bool> DeleteSectionShelfAsync(Guid id);
}