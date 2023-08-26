/*
﻿using Testapp.Models;
public class Program 
{
    private static void Main(string[] args)
    {
    Person pr = new Person();  
    Person pr1 = new Person();  
     pr.Name = "Nguyen hong a";
     pr.Address = "Ha Noi";
     pr.Age = 22;
     // gan gia tri doi tuong pr1
     pr1.Name = "Ha Van Tu";
     pr1.Address = "Nam Dinh";
     pr1.Age = 25;
    // Khai bao hai bien va gan gia tri
    String str = "Nguyen van Duy";
    int a =25;
    System.Console.WriteLine("{0} sinh nam {1}",str , pr.GetYearOfBirth(a));
    pr.Display();
    pr1.Display();
    }
}


*/


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
            //
            String str = "Ha Vu Quy";
            int a = 192105035;
            st.Display(str,a);
            st.Display();
        }
    }
}



/*

using Testapp.Models;
public class Program
{
    private static void Main(string[] args)
    {
    Fruit fr = new Fruit();
    Fruit fr1= new Fruit();
    fr.FullName = "Dua";
    fr.Mau = "Do";
    fr.Soluong = "32";
    //////
    fr1.FullName = "Tao";
    fr1.Mau = "Xanh";
    fr1.Soluong = "20";
    fr1.Display();
    fr.Display();
    }
    
}


﻿using Testapp.Models;
public class Program 
{
    private static void Main(string[] args)
    {
    Employee emp = new Employee();  
    Employee emp1 = new Employee();  
     emp.MaNV =" 1921050439";
     emp.TenNV =" Nguyen van B";
     emp.Tuoi = 25;
     emp. Luong ="250000000";
     //gan gt thuoc tinh pr1
     emp1.MaNV =" 18210503845";
     emp1.TenNV =" Tran Van Lap";
     emp1.Tuoi = 15;
     emp1. Luong ="2504440000";
     emp1.Display();
     emp.Display();
    }
}



using Testapp.Models;
public class Program 
{
    private static void Main(string[] args)
    {
    Sinhvien sv = new Sinhvien();  
    Sinhvien sv1 = new Sinhvien(); 
    sv.Hoten = "Ca Van Hao";
    sv.Diachi = "Da Nang";
    sv.Tuoi = 18;
    sv.SDT ="0397022573";
    ////////
    sv1.Hoten = "Cao Thuy Hao";
    sv1.Diachi = "HCM";
    sv1.Tuoi = 28;
    sv1.SDT ="028374345435";
     sv.Display();
     sv1.Display();
    }
}

*/