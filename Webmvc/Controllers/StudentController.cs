using Microsoft.AspNetCore.Mvc;

namespace Webmvc.Controllers;

    public class StudentController : Controller
    {
       public IActionResult  Index()
       {
         return View();
       }
      
    [HttpPost]
    public IActionResult Index(String FullName)
    {   
          ViewBag.abc=FullName;
          return View();

    }
    }
    
    
  

