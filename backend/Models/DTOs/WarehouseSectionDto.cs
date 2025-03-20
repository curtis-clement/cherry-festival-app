namespace backend.Models.DTOs;

public class WarehouseSectionDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ICollection<ShelfDto> Shelves { get; set; } = new List<ShelfDto>();
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}