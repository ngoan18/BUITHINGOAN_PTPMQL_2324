namespace Testapp.Models
{
    public class Student
    {
        public string Tensv {get; set; }
        public string Masv {get; set; }
        public string Khoa {get; set; }
        public void EnterData()
        {
            System.Console.Write("Tensv");
            Tensv = Console.ReadLine();
            System.Console.Write("Masv");
            Masv = Console.ReadLine();
            System.Console.Write("Khoa");
            Khoa = Console.ReadLine();
        }
        public void Display()
        {
            System.Console.WriteLine("{0}-MSV: {1}-Khoa:{2}",Masv, Tensv, Khoa);
        }
    }
}