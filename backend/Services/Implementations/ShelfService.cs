using backend.Data.Repositories.Interfaces;
using backend.Services.Interfaces;
using backend.Models.DTOs;
using backend.Data.Entities;

namespace backend.Services.Implementations;

public class ShelfService(IShelfRepository repository) : IShelfService
{
    public async Task<IEnumerable<ShelfDto>> GetAllSectionShelvesAsync(Guid sectionId)
    {
        var shelves = await repository.GetAllSectionShelvesAsync(sectionId);
        return shelves.Select(MapToDto);
    }

    public async Task<ShelfDto> GetSectionShelfByIdAsync(Guid shelfId)
    {
        var shelf = await repository.GetSectionShelfByIdAsync(shelfId);
        return MapToDto(shelf);
    }

    public async Task<ShelfDto> CreateSectionShelfAsync(ShelfDto shelfDto)
    {
        var shelf = MapToEntity(shelfDto);
        var createdShelf = await repository.CreateSectionShelfAsync(shelf);
        return MapToDto(createdShelf);
    }

    public async Task<bool> DeleteShelfAsync(Guid shelfId)
    {
        return await repository.DeleteSectionShelfAsync(shelfId);
    }

    private static Shelf MapToEntity(ShelfDto shelfDto)
    {
        return new Shelf
        {
            ShelfNumber = shelfDto.ShelfNumber,
            WarehouseSectionId = shelfDto.WarehouseSectionId,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
        };
    }


    private static ShelfDto MapToDto(Shelf shelf)
    {
        return new ShelfDto
        {
            Id = shelf.Id,
            ShelfNumber = shelf.ShelfNumber,
            WarehouseSectionId = shelf.WarehouseSectionId,
            CreatedAt = shelf.CreatedAt,
            UpdatedAt = shelf.UpdatedAt,
        };
    }
}