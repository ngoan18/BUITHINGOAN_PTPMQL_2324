namespace Console.Models;
public class Fruit
{
       public string Ten { get; set; }
        public string Soluong { get; set; }
   public void EnterData()
    {
        System.Console.Write("Ten =");
        Ten = Console.ReadLine();
        System.Console.Write("Soluong =");
        Soluong = Console.ReadLine();
    }
    public void Display()
    {
        System.Console.Write("{0}-{1}", Ten, Soluong);
    }


}