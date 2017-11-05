using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class BasicIf
    {
        static void Main(string[] args)
        {
            int x = 5;

            // xが正であれば表示する
            if (x > 0)
            {
                Console.WriteLine(x); // 結果:5
            }
            else
            {
                x *= 2;
            }
        }
    }
}
