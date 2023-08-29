namespace Testapp.Models
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
          try {
            // cau lenh co the gay ngoai le
            Age = Convert.ToInt16(System.Console.ReadLine());
        } catch(Exception e)
        {
            // cau lenh xu ly ngoai le
            Age = 0;
        }

       }
         public int GetYearOfBirth(int Age)
        {
            int yearOfBirth = 2023 - Age;
            return yearOfBirth;
        }
       public void Display()
       {
        System.Console.WriteLine("ID {0}-Ten:{1} - dia chi {2} - {3} tuoi",IDName,FullName, Address, Age);
       }
        public void Display2(string FullName, int Age)
       {
        System.Console.WriteLine("Sinh vien {0} - {1} tuoi", FullName, Age);
       }
    }
}