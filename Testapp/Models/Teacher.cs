namespace Testapp.Models
{
    public class Teacher : Fruit
    {
        public string TeacherCode { get; set; }
        public void EnterData()
    {
       //ke thua phuong thuc class Fruit
        base.EnterData();
        // phat trien nhap thong tin 
        System.Console.Write("Teacher Code = ");
        TeacherCode = System.Console.ReadLine();
    }
        public void Display()
    {
        //Ke thua lai pt class Pruit
        base.Display();
        //hien thi nhap thong tin 
        System.Console.Write("Ten giao vien: {0}", TeacherCode);
    }
    }
}