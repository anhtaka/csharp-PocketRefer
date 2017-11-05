using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class OperatorComp
    {
        static void Main(string[] args)
        {
            int x = 1, y = 2;

            x += 2;   // x = x + 2 と同じ
            x *= y;   // x = x * y と同じ

            Console.WriteLine(x);
        }
    }
}
