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
            Tensv = System.Console.ReadLine();
            System.Console.Write("Masv");
            Masv = System.Console.ReadLine();
            System.Console.Write("Khoa");
            Khoa = System.Console.ReadLine();
        }
        public void Display()
        {
            System.Console.WriteLine("{0}-Msv: {1}-Khoa:{2}",Tensv, Masv, Khoa);
        }
         public void Display(String Tensv, int Masv)
        {
            System.Console.WriteLine("{0}-Masv:{1}",Tensv, Masv);
        }

    }
}