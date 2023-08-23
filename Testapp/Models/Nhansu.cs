using Testapp.Models;
public class Nhansu
{
public string Tenns { get; set; }
public string Chucvu { get; set; }
public int Tuoi { get; set; }
public string Luong {get; set; }

public void EnterData()
    {
        System.Console.Write("Tenns =");
        Tenns = System.Console.ReadLine();
        System.Console.Write("Chucvu =");
        Chucvu = System.Console.ReadLine();
        System.Console.Write("Tuoi =");
        Tuoi = Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Luong =");
        Luong = System.Console.ReadLine();
    }
    public void Display()
    {
        System.Console.WriteLine("Tenns {0}-chucvu:{1}-{2} tuoi -luong:{3} vnd", Tenns, Chucvu, Luong);
    }
}