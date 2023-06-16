using bus_project.Data;
using Microsoft.AspNetCore.Mvc;

namespace bus_project.Controllers;

public class VehicleController : Controller
{
    private readonly DBContext _dbContext;

    public VehicleController(DBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult VehicleType()
    {
        var vehicleTypes = _dbContext.VehicleTypes.ToList();
        return View("~/Views/Vehicle/VehicleType.cshtml", vehicleTypes);

    }


}