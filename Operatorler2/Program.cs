using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            Console.WriteLine(x);
            x += 5;//x = x + 5
            Console.WriteLine(x);

            x = 10;
            Console.WriteLine(x);
            x -= 5;// x = x - 5
            Console.WriteLine(x);

            x = 10;
            Console.WriteLine(x);
            x *= 5; //x = x * 5
            Console.WriteLine(x);

            x = 10;
            Console.WriteLine(x);
            x /= 5;//x = x / 5
            Console.WriteLine(x);

            x = 10;
            Console.WriteLine(x);
            x %= 5; //x = x % 5
            Console.WriteLine(x);
        }
    }
}
