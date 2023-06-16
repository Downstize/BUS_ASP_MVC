using bus_project.Data;
using Microsoft.AspNetCore.Mvc;

namespace bus_project.Controllers;

public class RouteController : Controller
{
    private readonly DBContext _dbContext;

    public RouteController(DBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult RouteList()
    {
        var routesList = _dbContext.RoutesList.ToList();
        return View("~/Views/Route/RouteList.cshtml", routesList);

    }


}