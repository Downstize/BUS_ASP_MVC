using bus_project.Data;
using Microsoft.AspNetCore.Mvc;

public class DataController : Controller
{
    private readonly YourDbContext _dbContext;

    public DataController(YourDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult Index(string table)
    {
        
        switch (table)
        {
            case "TransportCompany":
                var transportCompanies = _dbContext.TransportCompanies.ToList();
                return View("~/Views/Company/TransportCompany.cshtml", transportCompanies);
            case "BusType":
                var busTypes = _dbContext.BusTypes.ToList();
                return View("~/Views/BusModels/BusType.cshtml", busTypes);
            case "VehicleType":
                var vehicleTypes = _dbContext.VehicleTypes.ToList();
                return View("~/Views/Vehicle/VehicleType.cshtml", vehicleTypes);
            case "StopAmmount":
                var stopsAmmount = _dbContext.StopsAmmount.ToList();
                return View("~/Views/Stop/StopAmmount.cshtml", stopsAmmount);
            case "RouteList":
                var routesList = _dbContext.RoutesList.ToList();
                return View("~/Views/Route/RouteList.cshtml", routesList);
            case "PointList":
                var pointsList = _dbContext.PointsList.ToList();
                return View("~/Views/Point/PointList.cshtml", pointsList);
            case "DriverList":
                var driversList = _dbContext.DriversList.ToList();
                return View("~/Views/Driver/DriverList.cshtml", driversList);
            default:
                return View("~/Views/Changes/ChangeSMTH.cshtml");
        }
    }
    
}