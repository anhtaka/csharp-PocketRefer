using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2
{
    class IsOperator
    {
        static void Main(string[] args)
        {
            string str = "abc";

            // 変数strがstringの場合、string型の変数sを作成する
            if (str is string s)
            {
                Console.WriteLine(s); // 結果：abc
            }

            // 文字列strがnullでない場合、その長さを変数lenに代入する
            if (str?.Length is int len)
            {
                Console.WriteLine(len); // 結果：3
            }

        }
    }
}
