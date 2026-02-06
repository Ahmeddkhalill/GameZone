using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameZone.ViewModels;

public class CreateGameFormViewModel
{
    [MaxLength(250)]
    public string Name { get; set; } = string.Empty;
    public IEnumerable<SelectListItem> Categories { get; set; } = [];

    [Display(Name = "Category")]
    public int CategoryId { get; set; }
    [Display(Name = "Supported Devices")]
    public List<int> SelectedDevices { get; set; } = [];
    public IEnumerable<SelectListItem> Devices { get; set; } = [];
    
    [MaxLength(2500)]
    public string Description { get; set; } = string.Empty;

    // validate extension and size
    public IFormFile Cover { get; set; } = default!;
}
 