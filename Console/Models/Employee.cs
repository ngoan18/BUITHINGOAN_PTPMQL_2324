/*
namespace Console.Models;
public class Employee
{
       public string Manhanvien { get; set; }
        public string Tennhanvien { get; set; }
        public string Tuoi { get; set; }
        public string Luong { get; set; }
   public void EnterData()
    {
        System.Console.Write("Ma nhan vien =");
        Manhanvien = System.Console.ReadLine();
        System.Console.Write("Ten nhan vien =");
        Tennhanvien = System.Console.ReadLine();
        System.Console.Write("Tuoi =");
        Tuoi = System.Console.ReadLine();
        System.Console.Write("Luong =");
        Luong = System.Console.ReadLine();
    }
       public string GetToLower(string  Tennhanvien)
        {
            String ToLower = Tennhanvien;
            return ToLower;
        }
    public void Display()
    {
        System.Console.WriteLine("ID {0}-{1}-{2} tuoi -luong:{3} vnd", Manhanvien, Tennhanvien, Tuoi, Luong);
    }
      public void Display2(string tennhanvien, string luong)
       {
        System.Console.WriteLine("nhan vien: {0} - luong:{1} vnd", tennhanvien, luong);
       }


}

*/
namespace Console.Models;
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



