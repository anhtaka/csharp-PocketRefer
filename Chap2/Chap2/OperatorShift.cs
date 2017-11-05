using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class OperatorShift
    {
        static void Main(string[] args)
        {
            int x = 5;      // 0101
            int y = x << 1; // 1010 (10進数なら10)

            Console.WriteLine(y);
        }
    }
}
