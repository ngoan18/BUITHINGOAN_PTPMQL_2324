
using Testapp.Models;
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
		Customer[] ctmArr = new Customer[n];
		// nhap thong tin sinh vien
			for (int i = 0; i < ctmArr.Length; i++)
			{
			System.Console.WriteLine("Nhap phan tu thu : {0} ",i);
			Customer ctm = new Customer();
			ctm.Nhapthongtin();
			ctmArr[i] = ctm;
			}
		// hien thi man hinh
		foreach(Customer ctm in ctmArr)
		{
			ctm.Hienthi();
		}
		// sua thong tin

		foreach(Customer ctm in ctmArr)
		{
			System.Console.WriteLine("stdArr.Name");
			Student stdupdate = new Student();
			stdupdate.Display();
		}
		// xoa thong tin

			foreach(Customer ctm in ctmArr)
		{
			ctm.Email= null;
			ctm.Hienthi();
		}
	}
    
    
  
}