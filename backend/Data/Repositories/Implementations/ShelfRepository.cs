using Microsoft.EntityFrameworkCore;
using backend.Data.Entities;
using backend.Data.Repositories.Interfaces;

namespace backend.Data.Repositories.Implementations;

public class ShelfRepository(ApplicationDbContext context) : IShelfRepository
{
    public async Task<IEnumerable<Shelf>> GetAllSectionShelvesAsync(Guid sectionId)
    {
        return await context.Shelves
            .Where(s => s.WarehouseSectionId == sectionId)
            .OrderBy(s => s.ShelfNumber)
            .ToListAsync();
    }

    public async Task<Shelf> GetSectionShelfByIdAsync(Guid id )
    {
        return await context.Shelves
            .FirstOrDefaultAsync(s => s.Id == id)
            ?? throw new KeyNotFoundException($"Shelf with ID {id} was not found");
    }

    public async Task<Shelf> CreateSectionShelfAsync(Shelf shelf)
    {
        await context.Shelves.AddAsync(shelf);
        await context.SaveChangesAsync();
        return shelf;
    }

    public async Task<bool> DeleteSectionShelfAsync(Guid id)
    {
        var shelf = await context.Shelves.FindAsync(id);
        if (shelf == null) return false;

        context.Shelves.Remove(shelf);
        await context.SaveChangesAsync();
        return true;
    }
}