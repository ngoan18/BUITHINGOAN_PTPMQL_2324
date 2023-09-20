using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
namespace MVCApp.Controllers;
public class DailyController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

     [HttpPost]
     public IActionResult Index(string Madaily, string Tendaily, string Diachi, string Nguoidaidien, string SDT)
    {
        ViewBag.c= Madaily + " - " + Tendaily + " - " + Diachi + " - " + Nguoidaidien + "-" + SDT;
        return View();
    }
}