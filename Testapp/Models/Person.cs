namespace Testapp.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public void EnterData()
        {
            System.Console.Write("Name");
            Name = Console.ReadLine();
            System.Console.Write("Address");
            Address = Console.ReadLine();
            System.Console.Write("Age");
            Age = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            System.Console.Write("{0}-dia chi:{1}-{2} tuoi",Name, Address, Age);
        }
    }
}