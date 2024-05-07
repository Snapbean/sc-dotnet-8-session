using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Snapbean.DevDay2024.KeyedServices.Interfaces;
using Snapbean.DevDay2024.KeyedServices.Models;

namespace Snapbean.DevDay2024.KeyedServices.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUsefulService _usefulService;

    public HomeController(ILogger<HomeController> logger, IUsefulService usefulService)
    {
        _logger = logger;
        _usefulService = usefulService;
    }

    public IActionResult Index()
    {
        _usefulService.DoSomethingUseful();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}