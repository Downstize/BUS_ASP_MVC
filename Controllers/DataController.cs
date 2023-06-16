using bus_project.Data;
using bus_project.Models;
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
    
    [HttpGet]
    public IActionResult StopsForRoute()
    {
        return View();
    }
    

    [HttpGet]
    public IActionResult BusesWithMoreThan180HP()
    {
        var buses = _dbContext.BusTypes.Where(b => b.engine_power > 180).ToList();

        return View("~/Views/BusModels/BusType.cshtml", buses);
    }

    // Действие для отображения маршрутов и соответствующих им моделей машин для выбранной компании (запрос: Маршруты компании "AVRORATUR")
//     public IActionResult RoutesForCompany(string companyName)
//     {
//         var routes = _dbContext.RoutesList.Where(r => r.company_name == companyName).ToList();
//         var vehicles = _dbContext.VehicleTypes.Where(v => routes.Any(r => r.route_number == v.route_number)).ToList();
//
//         var routesForCompanyViewModel = new RoutesForCompanyViewModel
//         {
//             Routes = routes,
//             Vehicles = vehicles
//         };
//
//         return View("RoutesForCompany", routesForCompanyViewModel);
//     }
//
//     // Добавьте другие действия в соответствии с вашими запросами
// }
// var vehicleModels = new List<VehicleModel>();
// foreach (var vehicle in vehicles)
// {
//     var vehicleModel = new VehicleModel
//     {
//         model_name = vehicle.model_name
//     };
//     vehicleModels.Add(vehicleModel);
// }

}