using bus_project.Data;
using Microsoft.AspNetCore.Mvc;

namespace bus_project.Controllers;

public class BusTypeController : Controller
{
    private readonly YourDbContext _dbContext;

    public BusTypeController(YourDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult BusType()
    {
        var busTypes = _dbContext.BusTypes.ToList();
        return View("~/Views/BusModels/BusType.cshtml", busTypes);

    }


}