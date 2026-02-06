namespace GameZone.Controllers;

public class GamesController(ApplicationDbContext context,ICategoriesService categoryService,
                            IDevicesService devicesService, IGamesService gamesService) : Controller
{
    private readonly ApplicationDbContext _context = context;
    private readonly ICategoriesService _categoryervice = categoryService;
    private readonly IDevicesService _devicesService = devicesService;
    private readonly IGamesService _gamesService = gamesService;

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        CreateGameFormViewModel viewModel = new()
        {
             Categories = _categoryervice.GetSelectList(),

             Devices = _devicesService.GetSelectList(),
        };

        return View(viewModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateGameFormViewModel model)
    {
        if (!ModelState.IsValid)
        {
            model.Categories = _categoryervice.GetSelectList();

            model.Devices = _devicesService.GetSelectList();
            return View(model);
        }

        await _gamesService.Create(model);

        // save cover to server

        return RedirectToAction(nameof(Index));
    }
}
