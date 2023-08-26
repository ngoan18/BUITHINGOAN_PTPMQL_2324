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
    pr.Display();
    pr1.Display();
    }
}




/*
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
*/

/*

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
*/
