using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Hello World!");


            /* 
            string => metin  
            int => tam sayı
            long => daha büyük tam sayı tutar
            float => ondalıklı sayı 0.123456
            double => ondalıklı sayı 0.123466578
            char => tek karakter tutar 
            bool => doğru - yanlış            
            */


            //Değişken tanımlama
            int tamSayi = 100;
            string metin = " Ben bir metinim";
            long buyuk_tam_sayi = 10000;
            float ondalıklıSayi = 5.565677f;
            double buyukOndalıklıSayi = 4.546546545745674575d;
            char tekKarakter = 'ş';
            bool isTrue = true;
            const string veri = " bu veri değişemez";

            
            
            Console.WriteLine(tamSayi);
            Console.WriteLine(metin);
            Console.WriteLine(buyuk_tam_sayi);
            Console.WriteLine(ondalıklıSayi);
            Console.WriteLine(buyukOndalıklıSayi);
            Console.WriteLine(tekKarakter);
            Console.WriteLine(isTrue);
            
            //String toplama
            string birlesmisMetin = metin + veri;
            tamSayi = 500;

            Console.WriteLine(birlesmisMetin);

            //çoklu değişken tanımlama
            int sayi1 = 0, sayi2 = 2, sayi4 = 4;


            int dosnusenSayi = (int)ondalıklıSayi;

            
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("girdiğin sayı : " + userInput);
        }
    }
}
