using BAL.resource;
using BOL.student;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCWITHDB.Models;

namespace MVCWITHDB.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        List<Student> slist=StudentResource.getAllStudent();
        this.ViewData["student_list"]=slist;
        return View();
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
