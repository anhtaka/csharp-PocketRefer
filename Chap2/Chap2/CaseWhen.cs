using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2
{
    class CaseWhen
    {
        static void Main(string[] args)
        {
            object obj = "abcd";

            switch (obj)
            {
                // objがint型のとき
                case int n:
                    Console.WriteLine(n);
                    break;
                // objが文字列かつ長さが３より大きいとき
                case string str when str.Length > 3:
                    Console.WriteLine(str); // 結果：abcd
                    break;
            }
        }
    }
}
