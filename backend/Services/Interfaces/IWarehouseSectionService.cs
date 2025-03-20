using backend.Models.DTOs;

namespace backend.Services.Interfaces;

public interface IWarehouseSectionService
{
    public Task<IEnumerable<WarehouseSectionDto>> GetAllSectionsWithShelvesAsync();
    public Task<WarehouseSectionDto> GetSectionByIdWithShelvesAsync(Guid id);
    public Task<WarehouseSectionDto> CreateSectionAsync(WarehouseSectionDto sectionDto);
    public Task<bool> DeleteSectionAsync(Guid id);
}