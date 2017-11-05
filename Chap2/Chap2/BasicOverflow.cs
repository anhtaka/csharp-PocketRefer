using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class BasicOverflow
    {
        static void Main(string[] args)
        {
            byte b = byte.MaxValue;
            b += 10;
            Console.WriteLine(b);         // 結果:9

            sbyte sb = sbyte.MaxValue;
            sb+=2;
            Console.WriteLine(sb);         // 結果:-127

            checked
            {
                float f1 = float.MaxValue;
                float f2 = 1e-20f;
                Console.WriteLine(f1 * 2);   // 結果:∞
                Console.WriteLine(f2 / f1);  // 結果:0
            }
        }
    }
}
