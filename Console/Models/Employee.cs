using System.ComponentModel.DataAnnotations;
namespace Console.Models
public class Employee
{
       public string Manhanvien { get; set; }
        public string Tennhanvien { get; set; }
        public string Tuoi { get; set; }
        public string Luong { get; set; }
   public void EnterData()
    {
        SystemAcl.Console.Write("Ma nhan vien =");
        Manhanvien = Console.ReadLine();
        SystemAcl.Console.Write("Ten nhan vien =");
        Tennhanvien = Console.ReadLine();
        SystemAcl.Console.Write("Tuoi =");
        Tuoi = Console.ReadLine();
        SystemAcl.Console.Write("Luong =");
        Luong = Console.ReadLine();
    }
    public void Display()
    {
        SystemAcl.Console.Write("{0}-{1}-{2}-{3}", Manhanvien, Tennhanvien, Tuoi, Luong);
    }


}