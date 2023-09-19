using Microsoft.AspNetCore.Mvc;
using Newapp.Models;
namespace Newapp.Controllers;
public class PersonController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
     public IActionResult Index( Person ps)
    {
        ViewBag.a= ps.PersonID + "-" + ps.Name + "-" + ps.SDT;
        return View();
    }
   
    [HttpPost]
     public IActionResult Create()

    {
        return View();
    }

}