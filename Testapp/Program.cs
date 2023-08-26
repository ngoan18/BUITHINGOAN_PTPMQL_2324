public class Program
{
    private static void Main(string[] args)
    {
        float a = 3;
        if(a>=8)
        {
            System.Console.WriteLine("Hoc sinh gioi");
        }
        else if(a>= 6.5)
        {
            System.Console.WriteLine("Hoc sinh kha");
        }
        else if(a>=5)
        {
            System.Console.WriteLine("Hoc sinh trung binh");
        }
        else if(a>=3.5)
        {
            System.Console.WriteLine("Hoc sinh yeu");
        }
        else
        {
            System.Console.WriteLine("Hoc sinh kem");
        }

    }
}