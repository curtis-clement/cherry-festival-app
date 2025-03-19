using backend.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Data.Seeders;

public class WarehouseSectionSeeder : IDataSeeder
{
    public async Task SeedAsync(ApplicationDbContext context)
    {
        if (!await context.WarehouseSections.AnyAsync())
        {
            var section = new WarehouseSection
            {
                Id = Guid.NewGuid(),
                Name = "Default Section",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await context.WarehouseSections.AddAsync(section);
            await context.SaveChangesAsync();
        }
    }
}
