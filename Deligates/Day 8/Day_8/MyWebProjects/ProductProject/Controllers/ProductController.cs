using Microsoft.AspNetCore.Mvc;
namespace ProductProject.Controllers;
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
        return View();
    }
    public IActionResult GetALLProduct()
    {
        BLL.Catalog ct = new Catalog();
        List<Product> p_arr = new List<Product>();
        p_arr = ct.getall();
        ViewData["Products"] = p_arr;
        return View();
    }
    public IActionResult ProductIdPage()
    {
        return View();
    }
    public IActionResult GetByID()
    {
        return View();
    }

}
