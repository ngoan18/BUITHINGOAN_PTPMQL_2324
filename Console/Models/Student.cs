namespace Console.Models;
public class Student
{
       public string Masinhvien { get; set; }
        public string Tensinhvien { get; set; }
        public string Tuoi { get; set; }
        public string Khoa { get; set; }
   public void EnterData()
    {
        System.Console.Write("Ma sinh vien =");
        Masinhvien = Console.ReadLine();
        System.Console.Write("Ten sinh vien =");
        Tensinhvien = Console.ReadLine();
        System.Console.Write("Tuoi =");
        Tuoi = Console.ReadLine();
        System.Console.Write("Khoa =");
        Khoa = Console.ReadLine();
    }
    public void Display()
    {
        System.Console.Write("{0}-{1}-{2} tuoi- Khoa{3}", Masinhvien, Tensinhvien, Tuoi, Khoa);
    }


}