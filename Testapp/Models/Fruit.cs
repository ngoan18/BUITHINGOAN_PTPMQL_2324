namespace Testapp.Models;

public class Fruit

{

    public string FullName { get; set; }
    public string Mau { get; set; }
    public string Soluong { get; set; }


   public void EnterData()

    {

        System.Console.Write("FullName =");
        FullName = Console.ReadLine();
        System.Console.Write("Mau");
        Mau= Console.ReadLine();
        System.Console.Write("Soluong =");
        Soluong = Console.ReadLine();

    }

    public void Display()

    {

        System.Console.Write("{0}-mau:{1}- so luong:{2}", FullName,Mau, Soluong);

    }







}