
namespace Testapp.Models;
public class Giaipt
{
    public int a {get; set; }
    public int b {get; set; }
    public int c {get; set; }

    double x1,x2,d;
    public void Nhapheso()
    {
        System.Console.Write("Nhap vao he so a = ");
            a = Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Nhap vao he so b = ");
            b = Convert.ToInt32(System.Console.ReadLine()); 
        System.Console.Write("Nhap vao he so b = ");
            c = Convert.ToInt32(System.Console.ReadLine()); 

    }
     public void Giaiptb2()
    {
        if (a == 0)
        {

        if(b==0)
        {
            if (c==0)
            {
            System.Console.WriteLine("PT co vo so nghiem");
            }
            else
            {
            System.Console.WriteLine("PT co vo nghiem");
    
            }
        }
        else
        {
            System.Console.WriteLine("PT co nghiem x = {0}", -c/b); 
        }
        }
        else
        {
            double d =b*b -4*a*c;
            if (d<0)
            {
            System.Console.WriteLine("PT vo nghiem");
            }
        else
        {
            if (d==0)
            {
            System.Console.WriteLine("PT co nghiem x = {0}", -b/(2*a));
            }
            else 
            {
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            System.Console.WriteLine("PT co 2 nghiem phan biet x1 = {0}, x2 = {1}",x1,x2); 
            }
        }
        }
    }

}


