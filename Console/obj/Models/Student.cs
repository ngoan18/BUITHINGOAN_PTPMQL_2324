using System.ComponentModel.DataAnnotations;
namespace Console.Models
public class Student
{
       public string Masinhvien { get; set; }
        public string Tensinhvien { get; set; }
        public string Tuoi { get; set; }
        public string Khoa { get; set; }
   public void EnterData()
    {
        SystemAcl.Console.Write("Ma sinh vien =");
        Masinhvien = Console.ReadLine();
        SystemAcl.Console.Write("Ten sinh vien =");
        Tensinhvien = Console.ReadLine();
        SystemAcl.Console.Write("Tuoi =");
        Tuoi = Console.ReadLine();
        SystemAcl.Console.Write("Khoa =");
        Khoa = Console.ReadLine();
    }
    public void Display()
    {
        SystemAcl.Console.Write("{0}-{1}-{2} tuoi-{3}", Masinhvien, Tensinhvien, Tuoi, Khoa);
    }


}