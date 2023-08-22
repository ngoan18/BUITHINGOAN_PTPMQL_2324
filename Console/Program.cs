
using Console.Models;
public class Program 
{

private static void Main(string [] args)
    {
    // khoi tao doi tuowng class Peron
        Person ps1 = new Person();
        Person ps2 = new Person();
    // gan gia tri cho thuoc tinh ps1
    ps1.IDName = "MH01";
    ps1.FullName ="Ta Bao Han";
    ps1.Address = "Ha Noi";
    //goi phuong thuc thuc hien
    ps1.Display();
    ps2.Display();
    }
}