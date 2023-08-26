public class Program
{
    private static void Main(string[] args)
    {
        int a, b;
        System.Console.Write("a=");
        a = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("b=");
        b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
            {
                System.Console.WriteLine("{0} lớn hơn {1}", a,b);
            }
            else if (a < b)
            {
                System.Console.WriteLine("{0} nhỏ hơn {1}", a, b);
            }
            else
            {
                System.Console.WriteLine("{0} bằng {1}", a, b);
            }
    }
}