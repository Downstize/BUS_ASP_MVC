using bus_project.Data;
using Microsoft.AspNetCore.Mvc;

namespace bus_project.Controllers;

public class TransportCompanyController : Controller
{
    private readonly YourDbContext _dbContext;

    public TransportCompanyController(YourDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult TransportCompany()
    {
        var transportCompanies = _dbContext.TransportCompanies.ToList();
        return View("~/Views/Company/TransportCompany.cshtml", transportCompanies);

    }


}
