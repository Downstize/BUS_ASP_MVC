using bus_project.Data;
using Microsoft.AspNetCore.Mvc;

namespace bus_project.Controllers;

public class VehicleController : Controller
{
    private readonly YourDbContext _dbContext;

    public VehicleController(YourDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult VehicleType()
    {
        var vehicleTypes = _dbContext.VehicleTypes.ToList();
        return View("~/Views/Vehicle/VehicleType.cshtml", vehicleTypes);

    }


}