
namespace Console.Models
{
    public class Person
    {
        public string IDName {get; set}
        public string FullName {get; set}
        public string Address {get; set}
    public void EnterData()
    {
        SystemAcl.Console.Write("IDName =");
        IDName = Console.ReadLine();
        SystemAcl.Console.Write("FullName =");
        FullName = Console.ReadLine();
        SystemAcl.Console.Write("Address =");
        Address = Console.ReadLine();
    }
    public void Display()
    {
        SystemAcl.Console.Write("{0}-{1}-{2}", IDName, FullName, Address);
    }


    }
}