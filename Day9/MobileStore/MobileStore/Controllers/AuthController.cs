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

    public IActionResult postRegistration(string fname,string lname,int mob,string email,string pass){
        Console.WriteLine("Insert data in json on acton registrstion.");
        List<Customer> li=new List<Customer>();
        li=Customer.Dser();
        if(li[0]!=null)
        foreach(Customer s in li){
            if(s.Email==email){
                return Redirect("/auth/Registration");
            }   
        }
        li.Add(new Customer(fname,lname,mob,email,pass));
        Customer.Serial(li);
        return Redirect("/auth/Login");
        //return View();
    } 

    public IActionResult Validate(string email, string password)
    {
         Console.WriteLine("Validating User credentials.... ");
        List<Customer> li=Customer.Dser();
        if(li!=null)
        foreach(Customer c in li){
            if(c.Email==email && c.Password==password){
                return Redirect("/home/IACSD");
            }
        }
        return Redirect("/auth/Welcome");

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
