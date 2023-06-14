using bus_project.Data;
using Microsoft.AspNetCore.Mvc;

namespace bus_project.Controllers;

public class PointController : Controller
{
    private readonly YourDbContext _dbContext;

    public PointController(YourDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult PointList()
    {
        var pointsList = _dbContext.PointsList.ToList();
        return View("~/Views/Point/PointList.cshtml", pointsList);

    }


}