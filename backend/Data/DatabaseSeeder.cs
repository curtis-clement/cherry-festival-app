using backend.Data.Seeders;

namespace backend.Data;

public static class DatabaseSeeder
{
    public static async Task SeedDatabase(ApplicationDbContext context)
    {
        var seeders = new IDataSeeder[]
        {
            new WarehouseSectionSeeder(),
        };

        foreach (var seeder in seeders)
        {
            await seeder.SeedAsync(context);
        }
    }
}