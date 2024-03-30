using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarsılastırmaOperatorleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 5;

            bool sonuc;

            sonuc = (x == y);
            Console.WriteLine("x y'ye eşit mi :" + sonuc);

            sonuc = (x != y);
            Console.WriteLine("x y'ye eşit değil mi :" + sonuc);

            sonuc = (x > y);
            Console.WriteLine("x y'den büyük mü : " + sonuc);

            sonuc = (x < y);
            Console.WriteLine("x y'den küçük mü : " + sonuc);

            sonuc = (x >= y);
            Console.WriteLine("x y'den büyük eşit mi : " + sonuc);

            sonuc = (x <= y);
            Console.WriteLine("x y'den küçük eşit mi : " + sonuc);


        }
    }
}
