﻿using Testapp.Models;

    public class Program 
{
    public static void Main(string[] args)
    {	
		int n=0;
		do
		{
		System.Console.Write("Nhap so sinh vien :");
		n = Convert.ToInt32(System.Console.ReadLine());
		} while (n<0);
		Student[] stdArr = new Student[n];
		// nhap thong tin sinh vien
			for (int i = 0; i < stdArr.Length; i++)
			{
			System.Console.WriteLine("Nhap phan tu thu : {0} ",i);
			Student std = new Student();
			std.input();
			stdArr[i] =std;
			}
		// hien thi man hinh
		foreach(Student std in stdArr)
		{
			std.Display();
		}
		// sua thong tin

		foreach(Student std in stdArr)
		{
			System.Console.WriteLine("stdArr.Khoa");
			Student stdupdate = new Student();
			stdupdate.Display();
		}
		// xoa thong tin

			foreach(Student std in stdArr)
		{
			std.Khoa=null;
			std.Display();
		}

    }

}