// using System.Diagnostics;
// using Microsoft.AspNetCore.Mvc;
// using MobileStore.Models;

// namespace MobileStore.Controllers;

// public class CustController : Controller
// {
//     private readonly ILogger<CustController> _logger;

//     public CustController(ILogger<CustController> logger)
//     {
//         Console.WriteLine("Inside Customer Controller");
//         _logger = logger;
//     }

//     public IActionResult Customer()
//     {
//         List<Customer> allCustomer = CustomerManagement.GetAllCustomer();
//         ViewData["catalog"] = allCustomer;
//         return View();
//     }

// }
