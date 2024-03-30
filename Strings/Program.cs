using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stringlerin toplanma özelliği
            string stringDegiskenim = "bugün hava çok güzel";
            string baskaStringDegiskenim = "dışarı çıkacağım ";

            string toplamstring = stringDegiskenim + baskaStringDegiskenim;
            Console.WriteLine(toplamstring);

            //stringlerin içineindexle değer yazdırma methodu
            int rastgeleBirSayi = 456;
            Console.WriteLine("Rasgele degerim: {0} \n başka bir değer: {1} {2}", rastgeleBirSayi, 65, 98);

            //stringlerin içerisine değişkei direkt yazdırma
            int rastgeleBirSayi2 = 456;
            Console.WriteLine($"Rastgele bir deger: {rastgeleBirSayi2}");


            //stringlerin içerisinde kaçış(escape) karakteri kullanma
            Console.WriteLine("Sabahattin Alinin \"Kuyucaklı Yusuf\"kitabı çok tuttu. ");

            //slash /
            //ters slash \

            string stringFonsksiyonlari = "BugGün Hava Çok GüZel";
            Console.WriteLine(stringFonsksiyonlari.ToUpper());
            //ctrl + space(boşluk tuşu) => örerileri gösterme kısayolu

            string value = "merhaba";
            Console.WriteLine(value[3]);
        }
    }
}
