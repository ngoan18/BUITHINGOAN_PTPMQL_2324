
namespace Console.Models
{
    public class Person
    {   
        public string IDName { get; set; }
       public string FullName { get; set; }
       public string Address { get; set; } 
       public string Age { get; set; }
       public void EnterData()
       {
        System.Console.Write("ID name = ");
        IDName = Console.ReadLine();
        System.Console.Write("Full name = ");
        FullName = Console.ReadLine();
        System.Console.Write("Address = ");
        Address = Console.ReadLine();
        System.Console.Write("Age = ");
        Age = Console.ReadLine();
       }
       public void Display()
       {
        System.Console.WriteLine("ID {0} - {1} - dia chi {2} - {3} tuoi",IDName,FullName, Address, Age);
       }
    }
}