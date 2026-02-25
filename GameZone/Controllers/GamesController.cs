namespace GameZone.Controllers;

public class GamesController(ICategoriesService categoryService,IDevicesService devicesService, IGamesService gamesService) : Controller
{

    private readonly ICategoriesService _categoryervice = categoryService;
    private readonly IDevicesService _devicesService = devicesService;
    private readonly IGamesService _gamesService = gamesService;

    public IActionResult Index()
    {
        var games = _gamesService.GetAll();
        return View(games);
    }

    public IActionResult Details(int id)
    {
        var game = _gamesService.GetById(id);

        if (game is null)
            return NotFound();

        return View(game);   
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
