namespace Testapp.Models;
public class Giaipt
{
// phuong trinh bac 1
    public int a {get; set; }
    public int b {get; set; }

    double x;
    public void Nhapheso()
    {
        System.Console.Write("Nhap vao he so a = ");
            a = Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Nhap vao he so b = ");
            b = Convert.ToInt32(System.Console.ReadLine()); 

    }
    public void Giaiptb1()
    {
        if (a == 0 && b == 0)
        {
            System.Console.WriteLine("PT co vo so nghiem");
        }
        else if(a == 0 && b !=0)
        {
             System.Console.WriteLine("PT co vo  nghiem");
        }
        else
        {
             x = (double) -b / a;
                System.Console.WriteLine("PT co nghiem x = {0}", -b/a);
        }


    }

}