using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class MathPow
    {
        public static void Main(string[] args)
        {
            //√225 = 25
            Console.WriteLine("Sqrt(225):" + Math.Sqrt(225));
            //√2
            Console.WriteLine("Sqrt(2):" + Math.Sqrt(2));
            //Pow(225,0.5) = √225
            Console.WriteLine("Pow(225,0.5):" + Math.Pow(225, 0.5));

            //Pow(729,1/3) = 729の立方根
            Console.WriteLine("Pow(729,1/3):" + Math.Pow(729, 1.0/3.0));

            //Pow(2,-3)
            Console.WriteLine("Pow(2,-3):" + Math.Pow(2,-3));
            Console.ReadKey();
        }
    }
}
