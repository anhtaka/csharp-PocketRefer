using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class MathLog
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Log(10):" + Math.Log(10));
            Console.WriteLine("Log2(65536):" + Math.Log(65536,2));
            Console.WriteLine("Log10(1000000):" + Math.Log10(1000000));

            Console.WriteLine("e:" + Math.E);
            Console.WriteLine("e^2:" + Math.Pow(Math.E,2));

            Console.ReadKey();
        }
    }
}
