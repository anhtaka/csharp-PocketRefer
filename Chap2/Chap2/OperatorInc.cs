using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class OperatorInc
    {
        static void Main(string[] args)
        {
            int x,y;
            x = 5;
            y = x++;              // *1
            Console.WriteLine(y); // 結果：5

            x = 5;
            y = ++x;              // *2
            Console.WriteLine(y); // 結果：6
        }
    }
}
