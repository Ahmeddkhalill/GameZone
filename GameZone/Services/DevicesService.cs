namespace GameZone.Services;

public class DevicesService(ApplicationDbContext context) : IDevicesService
{
    private readonly ApplicationDbContext _context = context;

    public IEnumerable<SelectListItem> GetSelectList()
    {
        return _context.Devices.Select(d => new SelectListItem
        {
            Value = d.Id.ToString(),
            Text = d.Name
        })
             .OrderBy(d => d.Text)
             .AsNoTracking()
              .ToList();
    }
}
