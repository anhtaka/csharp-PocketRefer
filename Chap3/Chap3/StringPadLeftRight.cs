using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class StringPadLeftRight
    {
        public static void Main(string[] args)
        {
            string s1 = "abcDEF123";

            //先頭に空白を入れて右寄せ
            Console.WriteLine(s1.PadLeft(12));

            //末尾に.を入れて左寄せ
            Console.WriteLine(s1.PadRight(18, '.'));

            //現在の文字列より短い長さの場合は、現在の文字列を返す
            Console.WriteLine(s1.PadLeft(3));

            Console.ReadKey();
        }
    }
}
