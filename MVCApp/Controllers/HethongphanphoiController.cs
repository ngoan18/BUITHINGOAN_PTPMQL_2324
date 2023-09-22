using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MVCApp.Models;
namespace MVCApp.Controllers;
public class HethongphanphoiController: Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
     public IActionResult Index( string MaHTPP, string TenHTPP)
    {
        ViewBag.ketqua= MaHTPP + " -" + TenHTPP ;
        return View();
    }
}
