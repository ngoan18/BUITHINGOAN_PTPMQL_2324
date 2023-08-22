namespace Console.Models;
public class Sinhvien
{
       public string hoten { get; set; }
        public string diachi { get; set; }
        public int Tuoi { get; set; }
        public string sdt { get; set; }
   public void EnterData()
    {
        System.Console.Write("hoten =");
        hoten = System.Console.ReadLine();
        System.Console.Write("diachi =");
        diachi = System.Console.ReadLine();
        System.Console.Write("Tuoi =");
        Tuoi = Convert.ToInt32(System.Console.ReadLine());;
        System.Console.Write("Luong =");
        sdt = System.Console.ReadLine();
    }
    public void Display()
    {
        System.Console.Write("{0}-diachi:{1}-{2} tuoi -sdt:{3}", hoten, diachi, Tuoi, sdt);
    }


}
