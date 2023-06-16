using bus_project.Data;
using Microsoft.AspNetCore.Mvc;

namespace bus_project.Controllers;

public class StopController : Controller
{
    private readonly DBContext _dbContext;

    public StopController(DBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult StopAmmount()
    {
        var stopsAmmount = _dbContext.StopsAmmount.ToList();
        return View("~/Views/Stop/StopAmmount.cshtml", stopsAmmount);

    }


}