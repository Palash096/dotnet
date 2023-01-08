using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SimpleLogin.Models;

namespace SimpleLogin.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Login()
    {
        Console.WriteLine("Invoking Home Controller Login method. ");
        return View();
    }

    public IActionResult Validate(string email, string password)
    {
        Console.WriteLine("Validate Credentials... ");
        if(email == "palashkardhekar5@gmail.com" && password == "palash"){
            Console.WriteLine("Customer is valid");
            return Redirect("/home/welcome");
        }
        return View();
    }

    public IActionResult Welcome()
    {
        Console.WriteLine("Invoking Home Controller Welcome method. ");
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
