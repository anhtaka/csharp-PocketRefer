using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class MathAbs
    {
        public static void Main(string[] args)
        {
            int i1 = -32;
            Console.WriteLine("intの絶対値:" + Math.Abs(i1));

            double d1 = -123.456;
            Console.WriteLine("doubleの絶対値:" + Math.Abs(d1));

            Console.ReadKey();
        }
    }
}
