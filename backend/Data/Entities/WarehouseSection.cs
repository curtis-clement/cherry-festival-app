namespace backend.Data.Entities;

public class WarehouseSection
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ICollection<Shelf> Shelves { get; set; } = new List<Shelf>();
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}