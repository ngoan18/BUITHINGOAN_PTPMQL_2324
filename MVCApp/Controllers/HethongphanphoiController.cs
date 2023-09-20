using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers;
public class HethongphanphoiController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

     public IActionResult Index( string MaHTPP, string TenHTPP)
    {
        ViewBag.b= MaHTPP + " -" + TenHTPP ;
        return View();
    }
    
}
