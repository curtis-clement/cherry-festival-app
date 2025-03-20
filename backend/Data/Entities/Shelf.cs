namespace backend.Data.Entities;

public class Shelf
{
    public Guid Id { get; set; }
    public int ShelfNumber { get; set; }
    public Guid WarehouseSectionId { get; set; }
    public WarehouseSection WarehouseSection { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

}