
namespace Testapp.Models
{
    public class Employee
    {
        public string MaNV { get; set;}
        public string TenNV { get; set;}
        public int Tuoi { get; set;}
        public string Luong { get; set;}
        public void EnterData()
        {
            System.Console.WriteLine("MaNV");
            MaNV = System.Console.ReadLine();
            System.Console.WriteLine("TenNV");
            TenNV = System.Console.ReadLine();
            System.Console.WriteLine("Tuoi");
            Tuoi = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Luong");
            Luong = System.Console.ReadLine();
        }
        public void Display()
        {
            System.Console.WriteLine("MSV:{0}-{1}-{2} tuoi-{3} vnd",MaNV,TenNV, Tuoi, Luong);
        }


    }


}