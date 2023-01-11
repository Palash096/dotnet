using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace EMartApplication.Controllers;

using BLL;
using BOL;


public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        CatalogManager manager=new CatalogManager();
        List<Product> allProducts=manager.GetAllProducts();
        this.ViewData["products"]=allProducts;
        return View();
    }

    public IActionResult Details()
    {
        return View();
    }



    

    
}
