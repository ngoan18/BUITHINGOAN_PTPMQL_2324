namespace Testapp.Models
{
   public class Student
    {
        public string Tensv;
        public int Tuoi;
        public string Khoa;
    public Student()
    {
        Tensv = "Bui Nam A";
        Tuoi = 0;
        Khoa = "CNTT";
    }
        public void input()
        {
            System.Console.Write("Tensv =");
            Tensv = System.Console.ReadLine();
            System.Console.Write("Tuoi =");
            Tuoi = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Khoa =");
            Khoa = System.Console.ReadLine();
        }
        public void Display()
        {
            System.Console.WriteLine("{0}-Tuoi:{1}-Khoa:{2}",Tensv,Tuoi, Khoa);
        }

    }
}