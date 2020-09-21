using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 2;

            Console.WriteLine("두변수의 합: " + (x + y));
            Console.WriteLine("두변수의 차: " + (x - y));
            Console.WriteLine("두변수의 곱은: " + (x * y));
            Console.WriteLine("두변수의 몫은: " + (x / y));
            Console.WriteLine("두변수의 나머지는: " + (x % y));
        }
    }
}
