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
    public IActionResult gptb2()
    {
        return View();
    }
  
 [HttpPost]
    public IActionResult gptb2 (int a, int b, int c)
     {
         double x1, x2, delta;
         string  thongbao;
       if(a==0){
                thongbao= "Khong la phuong trinh bac 2";
         if (b == 0)
                {
                
                    if (c == 0)
                    {
                        thongbao=" Phuong trinh co vo so nghiem.";
                    }
                  
                    else
                    {
                        thongbao= "Phuong trinh vo nghiem.";
                    }
                }
                else
                {
                    x1 = (double)-c / b;
                    thongbao= "Phuong trinh co nghiem duy nhat x = {0}" + (Math.Round(x1, 2));
                }
            }
            //nếu a != 0 thì ta bắt đầu giải phương trình bậc hai
            else
            {
                //tính delta
                delta = Math.Pow(b, 2) - 4 * a * c;
                //delta < 0 thì phương trình vô nghiệm
                if (delta < 0)
                {
                    thongbao="Phuong trinh vo nghiem." ;
                }
                //delta = 0 thì phương trình có hai nghiệm kép
                else if (delta == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    thongbao="Phuong trinh co nghiem kep x1 = x2 = {0}" + x1;
                }
                //delta > 0 thì phuong trình có hai nghiệm phân biệt
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    thongbao="Phương trình có 2 nghiệm pb X1="+ x1 +""+"và"+""+ "X2=" +x2;
                }
               
            }
            
             
             ViewBag.abc=thongbao;
            return View();
        }
      
           
      }
    

 

        
    
    
    
  

