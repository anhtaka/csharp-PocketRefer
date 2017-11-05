using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class OperatorRelation
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 2;

            bool z = x < y;           // zはfalseとなる

            bool b = true | false;   // bはtrueとなる

            Console.WriteLine(b);
        }
    }
}
