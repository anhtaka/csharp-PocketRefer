using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class BasicDowhile
    {
        static void Main(string[] args)
        {
            int n = 0;

            do
            {
                Console.WriteLine(n);  // 結果:0 （かならず1回は実行される）
                n--;
            } while (n > 0);

        }
    }
}
