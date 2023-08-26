/*
public class Program
{
private static void Main(string[] args)

    {
        string STR ="1123";
        int a = int.Parse(STR);
        Console.WriteLine("a =" +a);
    }
}


public class Program
{
private static void Main(string[] args)

    {
        string STR ="123";  // gia tri vao chuyen doi
        int ketqua;          // bien luu ket qua
        bool kiemtra =false; // bien kiem tra
        kiemtra = int.TryParse(STR,out(ketqua));  // chuyen doi du lieu
        Console.WriteLine("Ket qua =" +ketqua);
    }
}
*/
public class Program
{
    private static void Main(string[] args)
    {
        string str = "456";
        int a = Convert.ToInt32(str);
        Console.WriteLine("a = " + a);
    }
}