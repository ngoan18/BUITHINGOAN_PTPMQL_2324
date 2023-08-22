using System.ComponentModel.DataAnnotations;
namespace Console.Models
public class Fruit
{
       public string Ten { get; set; }
        public string Soluomg { get; set; }
   public void EnterData()
    {
        SystemAcl.Console.Write("Ten =");
        Ten = Console.ReadLine();
        SystemAcl.Console.Write("Soluong =");
        So luong = Console.ReadLine();
    }
    public void Display()
    {
        SystemAcl.Console.Write("{0}-{1}", Ten, soluong);
    }


}