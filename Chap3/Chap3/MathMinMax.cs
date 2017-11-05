using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class MathMinMax
    {
        public static void Main(string[] args)
        {
            double d1 = 123.456;
            double d2 = 100;
            Console.WriteLine("Max(d1,d2):" + Math.Max(d1,d2));
            Console.WriteLine("Min(d1,d2):" + Math.Min(d1, d2));

            Console.ReadKey();
        }
    }
}
