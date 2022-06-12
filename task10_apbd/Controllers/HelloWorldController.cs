using System.Diagnostics;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using task10_apbd.Models;

namespace task10_apbd.Controllers;

public class HelloWorldController : Controller
{
    private readonly ILogger<HelloWorldController> _logger;

    public HelloWorldController(ILogger<HelloWorldController> logger)
    {
        _logger = logger;
    }

   
    public IActionResult Index()
    {
        return View();
    }
    public string Privacy()
    {
        return "This is the Welcome action method...";
    }
    
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;

        return View();
    }
    
}
