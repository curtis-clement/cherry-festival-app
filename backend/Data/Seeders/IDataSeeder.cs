namespace backend.Data.Seeders;

public interface IDataSeeder
{
    public Task SeedAsync(ApplicationDbContext context);
}
