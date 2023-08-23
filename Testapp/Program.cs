using Testapp.Models;
public class Program
{
    public static void Main(string [] args)
    {
        Nhansu ns =new Nhansu();
        ns.Tenns = "Ha Han";
        ns.Chucvu = "Truong phong";
        ns.Phongban = "Ke toan";
        ns. Luong = "320";
        ns.Display();
    }
}
