namespace Console.Models;
public class Student : Person
{
public string StudentCode { get; set; }
        public void EnterData()
    {
        //ke thua phuong thuc class Person
        base.EnterData();
        // phat trien nhap thong tin Student code
        System.Console.Write("Student Code = ");
        StudentCode = System.Console.ReadLine();
    }
        public void Display()
    {
        //Ke thua lai pt class Person
        base.Display();
        //hien thi nhap thong tin Student code
        System.Console.Write("Ma sinh vien: {0}", StudentCode);
    }
}

