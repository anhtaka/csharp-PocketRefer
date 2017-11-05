using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class OperatorNull
    {
        string GetMethod(string str)
        {
            string def = "デフォルト値";

            // nullであれば、defを返す
            return str ?? def;  
        }

        static void Main()
        {
            string str1 = "文字列";
            string str2 = null;

            Console.WriteLine(
                new OperatorNull().GetMethod(str1)); // 結果:文字列
            Console.WriteLine(
                new OperatorNull().GetMethod(str2)); // 結果：デフォルト値
        }
    }
}
