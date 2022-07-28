using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Fastreportdemo.Services;

namespace Fastreportdemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly ReportService _reportService;

    public HomeController(ILogger<HomeController> logger, ReportService reportService)
    {
        _logger = logger;
        _reportService = reportService;
    }

    public IActionResult Index()
    {
        var report = _reportService.GetReports();
        return View(report);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}