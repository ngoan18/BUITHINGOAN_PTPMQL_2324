namespace Testapp.Models
{
    public class Employee
    {
        public string MaNV;
        public string TenNV;
        public int Tuoi;
        public string Luong;
        public Employee()
    
        {
            MaNV = "MN1";
            TenNV = " La Van Ca";
            Tuoi = 23;
            Luong ="1500000";
        }
        public void input()
        {
            System.Console.WriteLine("MaNV");
            MaNV = Console.ReadLine();
            System.Console.WriteLine("TenNV");
            TenNV = Console.ReadLine();
            System.Console.WriteLine("Tuoi");
            Tuoi = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Luong");
            Luong = Console.ReadLine();
        }
        public void Hienthi()
        {
            System.Console.WriteLine("MSV:{0}-{1}-{2} tuoi-{3} vnd",MaNV,TenNV, Tuoi, Luong);
        }


    }


}