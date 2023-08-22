using System.Xml;

/*internal class Program
{
    private static void Main(string[] args)
    {


// See https://aka.ms/new-console-template for more information
Console.WriteLine("XIN CHAO MON PHAT TRIEN PHAN PHAN");

// Khai báo  biến số và gán giá trị cho biến số đó hiển thị lên màn hình
int a = 5;
int b = 9;
Console.WriteLine("{0} + {1} = {2}",a,b,a+b);

// doc ky tu nhap vao tu ban phim va tra ve ma ky tu do
Console.Write("Nhap vao du lieu:");
int c = Console.Read();
Console.WriteLine("Du lieu vua nhap vao la :" + c);

// Khai báo các biến số và gán giá trị cho biến số đó hiển thị lên màn hình

String hoten = "Bui Thi Ngoan";
int tuoi = 22;
Console.WriteLine("Sinh vien {0}: {1} tuoi ", hoten,tuoi );

// Khai báo các hang so và gán giá trị cho biến số đó hiển thị lên màn hình
const string Hoten = "Le Van Nam";
const int NamLAMVIEc = 2;
Console.WriteLine("Nhan vien ten {0} - {1} nam kinh nghiem",Hoten, NamLAMVIEc); 

    }
}
*/
/// toan tu nhap 2 so tu ban phim va tinh tong, hieu ,tich,thuong, so vua nhap sau do in ra man hinh

internal class Program
{
    private static void Main(string[] args)
    {
        int u,v;
        System.Console.Write("nhap u = ");
        u = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("nhap v = ");
        v = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("{0} + {1} = {2}", u, v, u+v);
        System.Console.WriteLine("{0} - {1} = {2}", u, v, u-v);
        System.Console.WriteLine("{0} * {1} = {2}", u, v, u*v);
        System.Console.WriteLine("{0} / {1} = {2}", u, v, u/v);
        System.Console.WriteLine("{0} % {1} = {2}", u, v, u%v);
    }
} 
