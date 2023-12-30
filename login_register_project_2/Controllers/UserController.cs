using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UserProject.Models;
using BLL;
using BOL;

namespace UserProject.Controllers;

public class UserController : Controller
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    public IActionResult GetAll()
    {
        List<User> u_list = new List<User>();
        UserManager u_mgr = new UserManager();
        u_list = u_mgr.getAll();
        ViewData["Users"] = u_list;
        return View();
    }
    [HttpGet]
    public IActionResult Login()
    {  
        return View();
    }
    [HttpPost]
    public IActionResult Login(string email, string pass)
    {
        UserManager u_mgr = new UserManager();
        if(u_mgr.checkUser(email, pass))
            return this.RedirectToAction("Welcome");
        else
        {
            this.ViewData["msg"]="Invalid Email or Password !";
            return View(); 
        }

    }
    public IActionResult Welcome()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Register(string email, string uname, string pass)
    {
        UserManager u_mgr = new UserManager();
        if(u_mgr.register(email, uname, pass)){
            this.ViewData["msg"]="Register Successfully";
            return View();
        }
        else
        {
            this.ViewData["msg"]="Already Registered !";
            return View(); 
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
