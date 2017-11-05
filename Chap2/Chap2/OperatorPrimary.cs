using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class OperatorPrimary
    {
        static void Main(string[] args)
        {
            int a = 5, b=2;
            int x = 256, y = 1;

            a = a * 2 - b;      // a*2の次のbが減算される
            x = x >> y + 3;     // y+3が先に処理される
            
            Console.WriteLine("{0},{1}",a,x);
        }
    }
}
