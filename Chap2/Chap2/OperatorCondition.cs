using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class OperatorCondition
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;

            int c = (a < b) ? 1 : 2;   // cは、a<bがfalseなので、2となる
 
            Console.WriteLine(c);
        }
    }
}
