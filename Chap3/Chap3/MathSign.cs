using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class MathSign
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sign(-999.123):" + Math.Sign(-999.123));
            Console.WriteLine("Sign(0.000):" + Math.Sign(0.000));
            Console.WriteLine("Sign(256):" + Math.Sign(256));

            Console.ReadKey();
        }
    }
}
