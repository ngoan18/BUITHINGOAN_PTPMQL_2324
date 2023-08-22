namespace Console.Models;
public class Fruit
{
       public string Ten { get; set; }
        public string Soluong { get; set; }
   public void EnterData()
    {
        System.Console.Write("Ten =");
        Ten = System.Console.ReadLine();
        System.Console.Write("Soluong =");
        Soluong = System.Console.ReadLine();
    }
    public void Display()
    {
        System.Console.WriteLine("{0}- so luong:{1}", Ten, Soluong);
    }


}