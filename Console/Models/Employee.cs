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
        Manhanvien = Console.ReadLine();
        System.Console.Write("Ten nhan vien =");
        Tennhanvien = Console.ReadLine();
        System.Console.Write("Tuoi =");
        Tuoi = Console.ReadLine();
        System.Console.Write("Luong =");
        Luong = Console.ReadLine();
    }
    public void Display()
    {
        System.Console.Write("ID {0}-{1}-{2} tuoi -{3} vnd", Manhanvien, Tennhanvien, Tuoi, Luong);
    }


}
