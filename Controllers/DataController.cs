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
            default:
                return View("~/Views/Changes/ChangeSMTH.cshtml");
        }
    }

    // Другие методы для создания, редактирования и удаления данных
}