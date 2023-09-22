using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
namespace MVCApp.Controllers;
public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
     public IActionResult Index(string EmployeeId, string Name, string SDT, int Age) 
    {
        ViewBag.a= EmployeeId + " -" + Name + "- " + SDT + "-" + Age;
        return View();
    }
}