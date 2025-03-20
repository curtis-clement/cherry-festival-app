using backend.Data.Entities;

namespace backend.Data.Repositories.Interfaces;

public interface IWarehouseSectionRepository
{
    public Task<IEnumerable<WarehouseSection>> GetAllSectionsWithShelvesAsync();
    public Task<WarehouseSection> GetSectionByIdWithShelvesAsync(Guid id);
    public Task<WarehouseSection> CreateSectionAsync(WarehouseSection section);
    public Task<bool> DeleteSectionAsync(Guid id);
}