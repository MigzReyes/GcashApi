using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GCashApi.Models;

namespace GCashApi.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult GCashMain()
    {
        return View();
    }

}
