using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SMS.Web.Models;

namespace SMS.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.LongTime = DateTime.Now.ToLongTimeString();
        ViewBag.Message = "Time Now";

        return View();
    }
    public IActionResult About()
    {
        
        return View(new AboutViewModel { 
            Formed=new DateTime(2022,1,1),
            Message="This About Page was made by Sarah", 
            Title ="About Page"

        });


        
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
