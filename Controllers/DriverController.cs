using bus_project.Data;
using Microsoft.AspNetCore.Mvc;

namespace bus_project.Controllers;

public class DriverController : Controller
{
    private readonly DBContext _dbContext;

    public DriverController(DBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult DriverList()
    {
        var driversList = _dbContext.DriversList.ToList();
        return View("~/Views/Driver/DriverList.cshtml", driversList);

    }


}