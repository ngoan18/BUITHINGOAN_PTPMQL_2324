
using Testapp.Models;

    public class Program 
{
    private static void Main(string[] args)
    {
    
        {
            Student st = new Student();
            st.Tensv = "Bui Van Tuan";
            st.Masv = "1721050438";
            st.Khoa = "CNTT";
            st.Display();
        }
    }
}
****

using Testapp.Models;
public class Program
{
    private static void Main(string[] args)
    {
    Fruit fr = new Fruit();
    fr.FullName = "Dua";
    fr.Mau = "Do";
    fr.Soluong = "32";
    fr.Display();
    }
    
}
