using Testapp.Models;
public class Program 
{
    private static void Main(string[] args)
    {
     Person pr = new Person();   
     pr.Name = "Nguyen hong a";
     pr.Address = "Ha Noi";
     pr.Age = 22;
     pr.Display();
    }
}