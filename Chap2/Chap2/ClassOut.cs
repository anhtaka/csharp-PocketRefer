using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class ClassOut
    {
        // aの2乗と3乗を求める
        public void TestFunc(int a, out int b, out int c)
        {
            b = a * a;
            c = a * a * a;
        }
        static void Main()
        {
            // int x, y;
            new ClassOut().TestFunc(3, out int x, out int y);
            Console.WriteLine(x);     // 出力値：9
            Console.WriteLine(y);     // 出力値：27
        }
    }
}
