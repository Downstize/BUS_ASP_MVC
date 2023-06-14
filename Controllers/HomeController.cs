using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bus_project.Models;

namespace bus_project.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult MainPage()
    {
        return View();
    }

    public IActionResult ModelsOfBus()
    {
        return View();
    }
    
    public IActionResult TransportCompany()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}