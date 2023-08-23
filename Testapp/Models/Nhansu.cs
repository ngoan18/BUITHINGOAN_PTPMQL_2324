namespace Testapp.Models;
public class Nhansu
{
    public string Tenns { get; set; }
    public string Chucvu { get; set; }
    public string Phongban { get; set; }
    public string Luong { get; set; }
  public void EnterData()
    {
        System.Console.Write("Tenns =");
        Tenns = System.Console.ReadLine();
        System.Console.Write("Chucvu =");
        Chucvu = System.Console.ReadLine();
        System.Console.Write("Tuoi =");
        Phongban = System.Console.ReadLine();
        System.Console.Write("Luong =");
        Luong = System.Console.ReadLine();
    }
public void Display()
{
System.Console.WriteLine("Ten {0}-Chucvu: {1}- Phongban: {2}- {3} vnd", Tenns,Chucvu, Phongban, Luong);
}
}