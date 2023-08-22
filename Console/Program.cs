using System.Threading.Tasks.Dataflow;
using Console.Models;
public class Program 
{

private static void Main(string [] args)
    {
    // khoi tao doi tuowng class 
        Person ps1 = new Person();
        Person ps2 = new Person();
        Person ps = new Person();
        Employee em1 = new Employee();
        Student st1 = new Student();
        Fruit fr1 = new Fruit();
        Sinhvien sv1 =new Sinhvien();
    // gan gia tri cho thuoc tinh ps1
    ps1.IDName = "MH01";
    ps1.FullName ="Ta Bao Han";
    ps1.Address = "Ha Noi";
    ps1.Age = 22;
    // Khai bao hai bien va gan gia tri
    String str = "Nguyen van Duy";
    int a =25;
    System.Console.WriteLine("{0} sinh nam {1}",str , ps.GetYearOfBirth(a));


    // gan gia tri thuoc tinh p2
    ps2.IDName = "MH02";
    ps2.FullName ="Ta Van Kiet";
    ps2.Address = "Nam Dinh";
    ps2.Age = 35;
    // gan gia tri cho thuc tinh em1
    em1.Manhanvien = "NV02";
    em1.Tennhanvien = "Hoang ha";
    em1.Tuoi = "15";
    em1.Luong = "320"; 
    // gan gia tri cho thuoc tinh st1
    st1.Masinhvien = "SV01";
    st1.Tensinhvien ="Nam truong";
    st1.Tuoi = "25";
    st1.Khoa ="Kinh te";

    // gan gia tri cho thoc tinh fr1
    fr1.Ten= "CAM";
    fr1.Soluong = "15";

    // gan gia tri cho thuoc tinh sv1
    sv1.hoten ="Bui Ngoc Anh";
    sv1.diachi = "Hai Ba Trung";
    sv1.Tuoi = 18;
    sv1.sdt = "039797124";


    //goi phuong thuc thuc hien
    ps1.Display();
    ps2.Display();
    ps.Display2(str, a);
    em1.Display();
    st1.Display();
    fr1.Display();
    sv1.Display();
    }
}