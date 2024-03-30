using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
             /*
              
             / => bölme operatörü
             * => çarpma operatörü
             + => toplama operatörü
             - => çıkarma operatörü
             
             */

            double sayi1 = 10;
            double sayi2 = 5;

            double toplam = sayi1 + sayi2;
            double carpim = sayi1 * sayi2;
            double bolum = sayi1 / sayi2;
            double cıkarma = sayi1 - sayi2;
            double mod = sayi1 % sayi2;

            Console.WriteLine(toplam);
            Console.WriteLine(carpim);
            Console.WriteLine(bolum);
            Console.WriteLine(cıkarma);
            Console.WriteLine(mod);

            Console.WriteLine("------------------");
            int Tamsayımız = 8;
            Console.WriteLine(Tamsayımız++);
            Console.WriteLine(Tamsayımız);

            Tamsayımız = 8;
            Console.WriteLine(++Tamsayımız);
            Console.WriteLine(Tamsayımız);

            Tamsayımız = 8;
            Console.WriteLine(--Tamsayımız);
            Console.WriteLine(Tamsayımız);

            Tamsayımız = 8;
            Console.WriteLine(Tamsayımız--);
            Console.WriteLine(Tamsayımız);

        }
    }
}
