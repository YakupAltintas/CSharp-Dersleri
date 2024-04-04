using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6KOsulIfadeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if(doğru mu diye sorar)
            //{ 
            //        doğruysa burası çalışır.
            //}    

            //int AhmetinParasi = 5;
            //int DavutunParasi = 10;
            

            //if(AhmetinParasi > DavutunParasi)
            //{
            //    Console.WriteLine("Ahmetin Parası Davutunkinden çok");
            //}
            //if (AhmetinParasi < DavutunParasi)
            //{
            //    Console.WriteLine("Davutun Parası Ahmetinkinden çok");
            //}


            //if (AhmetinParasi > DavutunParasi)
            //{
            //    Console.WriteLine("Ahmetin Parası Davutunkinden çok");
            //}
            //else
            //{
            //    Console.WriteLine("Davutun Parası Ahmetinkinden çok");
            //}



            //&& => ve
            //|| => yada
            //! => tersini al

            //int AhmetinParasi = 5;
            //int DavutunParasi = 10;
            //int VelininParasi = 15;

            //if (AhmetinParasi > DavutunParasi && AhmetinParasi > VelininParasi)
            //{
            //    Console.WriteLine("En çok para ahmedin");
            //}else if (DavutunParasi > AhmetinParasi && DavutunParasi > VelininParasi)
            //{
            //    Console.WriteLine("En çok para Davutun");
            //}
            //else if (VelininParasi > AhmetinParasi && VelininParasi > DavutunParasi)
            //{
            //    Console.WriteLine("En çok para velinin");
            //}

            bool cilek = true;
            bool armut = false;
            bool elma = true;

            if (cilek || armut)
            {
                Console.WriteLine("Sepetimdeki meyveler güzel");
            }
            
            if (armut && elma )
            {
                Console.WriteLine("Sepetimdeki meyveler Baya iyi");
            }
            if (!armut)
            {
                Console.WriteLine("Sepetimde armut var!");

            }

            //Short if
            //(koşul) ? true sonucu: false sonucu

            bool kontrol = (5 == 2) ? true : false;
            Console.WriteLine(kontrol);

        }
    }
}
