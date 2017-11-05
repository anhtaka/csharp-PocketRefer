using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class OperatorBit
    {
        static void PrintBit(int b)  // 2進数で表示する
        {
            string tmp = "00000000" + Convert.ToString(b, 2);
            Console.WriteLine(tmp.Substring(tmp.Length - 8, 8));
        }
        static void Main()
        {
            int a = 3;    //    00000011
            int b = 17;   //    00010001
            OperatorBit.PrintBit(a);     // 結果: 00000011
            OperatorBit.PrintBit(b);     // 結果: 00010001

            a = a & b;    // a: 00000001
            b = a | b;    // b: 00010011
            OperatorBit.PrintBit(a & b); // 結果: 00000001
            OperatorBit.PrintBit(a | b); // 結果: 00010011
        }
    }
}
