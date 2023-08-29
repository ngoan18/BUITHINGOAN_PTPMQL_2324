namespace Testapp.Models;
public class Fruit
{
    public string FullName { get; set; }
    public string Mau { get; set; }
    public string Soluong { get; set; }
    public int SDT { get; set; }
   public void EnterData()

    {

        System.Console.Write("FullName =");
        FullName = System.Console.ReadLine();
        System.Console.Write("Mau =");
        Mau= System.Console.ReadLine();
        System.Console.Write("Soluong =");
        Soluong = System.Console.ReadLine();
        System.Console.Write("SDT =");
         try{
                SDT = Convert.ToInt16(Console.ReadLine());

            }catch(Exception e)
            {
                //cau lenh xu li ngoai le
                SDT = 0;
            }

    }

    public void Display()

    {

        System.Console.Write("{0}-mau:{1}- so luong:{2}- sdt: {3}", FullName,Mau, Soluong,SDT);

    }







}