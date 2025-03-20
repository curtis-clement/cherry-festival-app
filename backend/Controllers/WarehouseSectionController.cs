using Microsoft.AspNetCore.Mvc;
using backend.Services.Interfaces;
using backend.Models.DTOs;

namespace backend.Controllers;

[ApiController]
[Route("api/warehouse-sections")]
public class WarehouseSectionController(IWarehouseSectionService sectionService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllSections()
    {
        var sections = await sectionService.GetAllSectionsWithShelvesAsync();
        return Ok(sections);
    }

    [HttpGet("section/{id}")]
    public async Task<IActionResult> GetSectionById(Guid id)
    {
        try
        {
            var section = await sectionService.GetSectionByIdWithShelvesAsync(id);
            return Ok(section);
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { message = ex.Message });
        }
    }

    [HttpPost]
    public async Task<IActionResult> CreateSection(WarehouseSectionDto sectionDto)
    {
        var createdSection = await sectionService.CreateSectionAsync(sectionDto);
        return CreatedAtAction(nameof(GetSectionById), new { id = createdSection.Id }, createdSection);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSection(Guid id)
    {
        var success = await sectionService.DeleteSectionAsync(id);
        return success ? NoContent() : NotFound();
    }
}