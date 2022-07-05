using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.HesapMakinesi.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exception

            //int a = 10;
            //int b = 20;
            //string c = "30";
            //Console.WriteLine(a+c+b);
            //Console.Write("Bir sayı giriniz:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci sayı giriniz:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Toplam:{0}", sayi1 + sayi2);



            //decimal,double,float,long,ulong,byte,sbyte,short,ushort,int,uint
            

            Console.WriteLine($"Max(INT):{int.MaxValue}");
            Console.WriteLine($"Min(INT):{int.MinValue}");
            Console.WriteLine($"Max(Long):{long.MaxValue}");

            Console.WriteLine("Bir byte giriniz:");
            byte b = Convert.ToByte(Console.ReadLine());


            int buYil = DateTime.Now.Year;
            





            Console.ReadKey();
        }
    }
}
