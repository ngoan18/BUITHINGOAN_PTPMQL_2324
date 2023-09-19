
using Microsoft.AspNetCore.Mvc;
namespace Newapp.Controllers;

public class DemoController : Controller
{
    public IActionResult Index ()
    {
            return View();
    }

    [HttpPost]
    public IActionResult Index (string FullName)
    {
          ViewBag.abc= "Ta Thai Ha: =" + FullName;

         return View();
    }
     public IActionResult Luong()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Luong(string Luongcb, string Heso, string Phucap)
    {
        double lcb =0, hs =0, pc =0, luong = 0;
        string Ketqua;
        if(!String.IsNullOrEmpty(Luongcb)) lcb = Convert.ToDouble(Luongcb);
        if(!String.IsNullOrEmpty(Heso)) hs = Convert.ToDouble(Heso);
        if(!String.IsNullOrEmpty(Phucap)) pc = Convert.ToDouble(Phucap);
        luong = lcb*hs+pc;
        Ketqua = "Lương của bạn là: " + luong;
        ViewBag.abc=Ketqua;
        return View();
    }
}

