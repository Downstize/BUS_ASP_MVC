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
    
    public IActionResult TransportCompany()
    {
        var transportCompanies = _dbContext.TransportCompanies.ToList();
        return View("~/Views/Company/TransportCompany.cshtml", transportCompanies);

    }
// Метод для добавления новой транспортной компании (показ формы)
    public IActionResult CreateCompany()
    {
        var model = new TransportCompanyModel.TransportCompany();
        return View("~/Views/Company/CreateCompany.cshtml", model);
    }

// Метод для сохранения новой транспортной компании
    [HttpPost]
    public IActionResult CreateCompany(TransportCompanyModel.TransportCompany company)
    {
        if (ModelState.IsValid)
        {
            _dbContext.TransportCompanies.Add(company);
            _dbContext.SaveChanges();
            return RedirectToAction("TransportCompany");
        }

        return View("~/Views/Company/CreateCompany.cshtml", company);
    }

// Метод для редактирования существующей транспортной компании (показ формы)
    public  IActionResult EditCompany(string id)
    {
        var company =  _dbContext.TransportCompanies.FirstOrDefault(c => c.company_name == id);
        if (company == null)
        {
            return NotFound();
        }

        return View("~/Views/Company/EditCompany.cshtml", company);
    }

    [HttpPost]
    public IActionResult EditCompany(string id, TransportCompanyModel.TransportCompany company)
    {
        if (ModelState.IsValid)
        {
            var existingCompany = _dbContext.TransportCompanies.Find(id);
            if (existingCompany == null)
            {
                return NotFound();
            }

            existingCompany.company_name = company.company_name;
            existingCompany.contact_info = company.contact_info;
            existingCompany.address = company.address;
            // Обновите другие поля, если таковые имеются

            _dbContext.SaveChanges();
            return RedirectToAction("TransportCompany");
        }

        return View("~/Views/Company/EditCompany.cshtml", company);
    }
    
    [HttpGet]
    public IActionResult DeleteCompany(string id)
    {
        var company = _dbContext.TransportCompanies.FirstOrDefault(c => c.company_name == id);
        if (company == null)
        {
            return NotFound();
        }

        return View("~/Views/Company/DeleteCompany.cshtml", company);
    }

    [HttpPost]
    public IActionResult DeleteCompanyConfirmed(string id)
    {
        var company = _dbContext.TransportCompanies.FirstOrDefault(c => c.company_name == id);
        if (company == null)
        {
            return NotFound();
        }

        _dbContext.TransportCompanies.Remove(company);
        _dbContext.SaveChanges();
        return RedirectToAction("TransportCompany");
    }
    
}