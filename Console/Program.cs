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

// chuyen doi du lieu
String str= "123";
int m = Convert.ToInt32(str);
System.Console.WriteLine("m= " + m );

// toan tu nhap 2 so tu ban phim vaf tinh tong so vua nhap sau do in ra man hinh
int f,w;
System.Console.Write("f =");
f = Convert.ToInt32(Console.ReadLine());
System.Console.Write("w =");
w= Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("{0} + {1} ={2}", f,w, f+w);




