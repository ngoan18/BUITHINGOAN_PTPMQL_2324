using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
namespace MVCApp.Controllers;
public class PersonController: Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
     public IActionResult Index( string PersonId, string FullName, string Address)
    {
        ViewBag.abc = PersonId + "-" + FullName + " - " + Address;
        return View();
    }
}