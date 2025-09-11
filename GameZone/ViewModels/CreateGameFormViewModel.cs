using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameZone.ViewModels;

public class CreateGameFormViewModel
{
    [MaxLength(250)]
    public string Name { get; set; } = string.Empty;
    public IEnumerable<SelectListItem> Categories { get; set; } = [];
    public int CategoryId { get; set; }
    public List<int> SelectedDevices { get; set; } = [];
    public IEnumerable<SelectListItem> Devices { get; set; } = [];
    
    [MaxLength(2500)]
    public string Description { get; set; } = string.Empty;
    public IFormFile Cover { get; set; } = default!;
}
 