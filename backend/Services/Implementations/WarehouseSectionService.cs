using backend.Data.Repositories.Interfaces;
using backend.Services.Interfaces;
using backend.Models.DTOs;
using backend.Data.Entities;

namespace backend.Services.Implementations;

public class WarehouseSectionService(IWarehouseSectionRepository repository) : IWarehouseSectionService
{
    public async Task<IEnumerable<WarehouseSectionDto>> GetAllSectionsWithShelvesAsync()
    {
        var sections = await repository.GetAllSectionsWithShelvesAsync();
        return sections.Select(MapToDto);
    }

    public async Task<WarehouseSectionDto> GetSectionByIdWithShelvesAsync(Guid id)
    {
        var section = await repository.GetSectionByIdWithShelvesAsync(id);
        return MapToDto(section);
    }

    public async Task<WarehouseSectionDto> CreateSectionAsync(WarehouseSectionDto dto)
    {
        var section = MapToEntity(dto);
        var createdSection = await repository.CreateSectionAsync(section);
        return MapToDto(createdSection);
    }

    public async Task<bool> DeleteSectionAsync(Guid id)
    {
        return await repository.DeleteSectionAsync(id);
    }

    private static WarehouseSectionDto MapToDto(WarehouseSection section)
    {
        return new WarehouseSectionDto
        {
            Id = section.Id,
            Name = section.Name,
            Description = section.Description,
            Shelves = section.Shelves.Select(s => new ShelfDto
            {
                Id = s.Id,
                ShelfNumber = s.ShelfNumber,
                WarehouseSectionId = s.WarehouseSectionId,
                CreatedAt = s.CreatedAt,
                UpdatedAt = s.UpdatedAt
            }).ToList(),
            CreatedAt = section.CreatedAt,
            UpdatedAt = section.UpdatedAt,
        };
    }

    private static WarehouseSection MapToEntity(WarehouseSectionDto dto)
    {
        return new WarehouseSection
        {
            Name = dto.Name,
            Description = dto.Description,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };
    }
}