using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class OperatorArith
    {
        static void Main(string[] args)
        {
            int x = 15, y = 16;

            Console.WriteLine((x + y) / 2);  // 結果：15 (15.5ではない)

            x = 17;
            y = 4;

            Console.WriteLine(x % y);         // 結果：1
            Console.WriteLine(x % 4.5);       // 結果：3.5
        }

    }
}
