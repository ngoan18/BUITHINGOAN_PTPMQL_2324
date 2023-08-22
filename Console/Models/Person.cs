
namespace Console.Models
{
    public class Person
    {   
        public string IDName { get; set; }
       public string FullName { get; set; }
       public string Address { get; set; } 
       public int Age { get; set; }
       public void EnterData()
       {
        System.Console.Write("ID name = ");
        IDName = System.Console.ReadLine();
        System.Console.Write("Full name = ");
        FullName = System.Console.ReadLine();
        System.Console.Write("Address = ");
        Address = System.Console.ReadLine();
        System.Console.Write("Age = ");
        Age = Convert.ToInt32(System.Console.ReadLine());;
       }
       public void Display()
       {
        System.Console.WriteLine("ID {0}-Ten:{1} - dia chi {2} - {3} tuoi",IDName,FullName, Address, Age);
       }
    }
}