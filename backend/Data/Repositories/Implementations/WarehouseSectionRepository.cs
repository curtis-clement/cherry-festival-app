using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using backend.Data.Entities;
using backend.Data.Repositories.Interfaces;
using backend.Data;

namespace backend.Data.Repositories.Implementations;

public class WarehouseSectionRepository(ApplicationDbContext context) : IWarehouseSectionRepository
{
    public async Task<IEnumerable<WarehouseSection>> GetAllSectionsWithShelvesAsync()
    {
        return await context.WarehouseSections
            .Include(ws => ws.Shelves)
            .OrderBy(ws => ws.CreatedAt)
            .ToListAsync();
    }

    public async Task<WarehouseSection> GetSectionByIdWithShelvesAsync(Guid id)
    {
        return await context.WarehouseSections
            .Include(ws => ws.Shelves)
            .FirstOrDefaultAsync(ws => ws.Id == id)
            ?? throw new KeyNotFoundException($"Section with ID {id} was not found");
    }

    public async Task<WarehouseSection> CreateSectionAsync(WarehouseSection section)
    {
        await context.WarehouseSections.AddAsync(section);
        await context.SaveChangesAsync();
        return section;
    }

    public async Task<bool> DeleteSectionAsync(Guid id)
    {
        var section = await context.WarehouseSections.FindAsync(id);
        if (section == null) return false;

        context.WarehouseSections.Remove(section);
        await context.SaveChangesAsync();
        return true;
    }
}