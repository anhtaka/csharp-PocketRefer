using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class BasicWhile
    {
        static void Main(string[] args)
        {
            int n = 3;

            while (n > 0)
            {
                Console.WriteLine(n);
                n--;
            }
        }
    }
}
