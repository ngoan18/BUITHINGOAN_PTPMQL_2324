using System.Xml;

internal class Program
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

// toan tu nhap 2 so tu ban phim va tinh tong, hieu ,tich,thuong, so vua nhap sau do in ra man hinh

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


//  cau lenh if-else
float d =7;
if (d>=8){
    System.Console.WriteLine("Hoc sinh gioi");
}   
else if(d>=6.5){
    System.Console.WriteLine("Hoc sinh kha");
} 
else if (d>=5){
    System.Console.WriteLine("Hoc sinh trung binh");
}else if (d>=3.5){
    System.Console.WriteLine("Hoc sinh kem");
}else {
    System.Console.WriteLine("Hoc sinh yeu");
}

//
int p = 10;
if(p<0){
    System.Console.WriteLine("{0} la so nguyen am", p);
} else{
    if(p%2 ==0) {
        System.Console.WriteLine("{0} la so nguyen duong chan", p);
    } else {
        System.Console.WriteLine("{0} la so nguyen duong le", p);
    }
}
    
// Toan tu so sanh 
//nhap vao 2 ky tu so sanhs 2 so va in ra ket qua man hinh
int m,n;
System.Console.WriteLine("nhap m");
m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("nhap n");
n = Convert.ToInt32(Console.ReadLine());
 if (m > n)
            {
                System.Console.WriteLine("{0} lớn hơn {1}", m,n);
            }
            else if (m < n)
            {
                System.Console.WriteLine("{0} nhỏ hơn {1}", m, n);
            }
            else
            {
                System.Console.WriteLine("{0} bằng {1}", m, n);
            }

/*// cau lenh SWITCH-CASE
int day =5;
switch(day)
{
    case 1: System.Console.WriteLine("Chu nhat"); break;
    case 2: System.Console.WriteLine("thu 2"); break;
    case 3: System.Console.WriteLine("thu 3"); break;
    case 4: System.Console.WriteLine("thu 4"); break;
    case 5: System.Console.WriteLine("thu 5"); break;
    case 6: System.Console.WriteLine("thu 6"); break;
    case 7: System.Console.WriteLine("thu 7"); break;
    default :
    System.Console.WriteLine("Khong phai ngay trong tuan");
    break;

}


// cau truc vong lap for
for (int i=0; i< 10; i++)
{
    System.Console.WriteLine("vong lap thu {0}", i);
}

// cau truc vong lap white
int k=1;
while(k < 5)

{
    System.Console.WriteLine("vong lap thu {0}", k);
    k++;
}

//  cau truc do while

int h=1;
do

{
    System.Console.WriteLine("vong lap thu {0}", h);
    h++;
} while (h<6);


  

// lenh break va continue
for (int l=0; l<10; l++)
{
    if(l==5) break;
    System.Console.WriteLine("vong lap thu {0}",l);
}


/// 
for (int j=0; j<10; j++)
{
    if(j==5) continue;
    System.Console.WriteLine("vong lap thu {0}",j);
}

    }
}


    

