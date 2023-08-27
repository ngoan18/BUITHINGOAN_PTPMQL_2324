namespace Testapp.Models
{
    public class Sinhvien
    {
        public string Hoten { get; set; }
        public string Diachi { get; set; }
        public int Tuoi { get; set;}
        public string SDT { get; set; }
        public void Data()
        {
            System.Console.Write("Hoten");
            Hoten = System.Console.ReadLine();
            System.Console.Write("Diachi");
            Diachi = System.Console.ReadLine();
            System.Console.Write("Tuoi");
            Tuoi = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("SDT");
            SDT = System.Console.ReadLine();
        }
        public  void Display()
        {
            System.Console.WriteLine("{0}-Dia chi:{1}-{2} tuoi-SDT:{3}",Hoten, Diachi,Tuoi,SDT);
        }
    }
}