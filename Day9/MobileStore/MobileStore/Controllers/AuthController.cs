using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MobileStore.Models;

namespace MobileStore.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Validate(string email, string password)
    {
        Console.WriteLine("Validate Credentials... ");
        if(email == "palashkardhekar5@gmail.com" && password == "palash"){
            Console.WriteLine("Customer is valid");
            return Redirect("/auth/Welcome");
        }
        return View();
    }

    public IActionResult Welcome()
    {
        Console.WriteLine("Invoking Home Controller Welcome method. ");
        return View();
    }

    public IActionResult Registration()
    {
        Console.WriteLine("Invoking Home Controller Registration method. ");
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
