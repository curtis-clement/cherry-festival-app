using backend.Models.DTOs;

namespace backend.Services.Interfaces;

public interface IShelfService
{
    public Task<IEnumerable<ShelfDto>> GetAllSectionShelvesAsync(Guid sectionId);
    public Task<ShelfDto> GetSectionShelfByIdAsync(Guid id);
    public Task<ShelfDto> CreateSectionShelfAsync(ShelfDto shelfDto);
    public Task<bool> DeleteShelfAsync(Guid id);
}