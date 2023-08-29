namespace Testapp.Models
{
    public class Customer 
    {
        public string Name { get; set; }
        public string Diachi { get; set; }
        public string Email { get; set; }
    public void Nhapthongtin()
    {
        Console.WriteLine("Name = " );
        Name = Console.ReadLine();
        Console.WriteLine("Diachi");
        Diachi = Console.ReadLine();
        Console.WriteLine("Email");
        Email = Console.ReadLine();
    }
    public void Hienthi()
    {
        System.Console.WriteLine("Ten: {0}- DC: {1} - Email: {2}", Name, Diachi, Email);
    }
    }
    
}
