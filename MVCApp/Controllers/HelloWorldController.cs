using Microsoft.AspNetCore.Mvc;
namespace MVCApp.Controllers;
public class HelloWorldController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public string Welcome()
    {
        return "This is the welcome action methoh..";
    }
}