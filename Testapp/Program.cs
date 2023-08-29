
using Testapp.Models;
    public class Program 
{
    public static void Main(string[] args)
    {	
		int n=0;
		do
		{
		System.Console.Write("Nhan vien :");
		n = Convert.ToInt32(System.Console.ReadLine());
		} while (n<0);
		Employee[] empArr = new Employee[n];
		// nhap thong tin sinh vien
			for (int i = 0; i < empArr.Length; i++)
			{
			System.Console.WriteLine("Nhap phan tu thu : {0} ",i);
			Employee emp = new Employee();
			emp.input();
			empArr[i] = emp;
			}
		// hien thi man hinh
		foreach(Employee emp in empArr)
		{
			emp.Hienthi();
		}
		// sua thong tin

		foreach(Employee ctm in empArr)
		{
			System.Console.WriteLine("empArr.TenNV");
			Employee emp = new Employee();
			emp.Hienthi();
		}
		// xoa thong tin

			foreach(Employee emp in empArr)
		{
			emp.TenNV= null;
			emp.Hienthi();
		}
	}
    
    
  
}