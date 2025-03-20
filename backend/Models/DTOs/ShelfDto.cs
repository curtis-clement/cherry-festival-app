namespace backend.Models.DTOs;

public class ShelfDto
{
    public Guid Id { get; set; }
    public int ShelfNumber { get; set; }
    public Guid WarehouseSectionId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}