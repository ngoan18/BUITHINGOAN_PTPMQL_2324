
namespace Testapp.Models;
public class Employee : Person
{
public string EmployeeCode { get; set; }
        public void EnterData()
    {
        //ke thua phuong thuc class Person
        base.EnterData();
        // phat trien nhap thong tin Employee code
        System.Console.Write("Employee Code = ");
        EmployeeCode = System.Console.ReadLine();
    }
        public void Display()
    {
        //Ke thua lai pt class Person
        base.Display();
        //hien thi nhap thong tin Eployee code
        System.Console.Write("Ma nhan vien: {0}", EmployeeCode);
    }
}