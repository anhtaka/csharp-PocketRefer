using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class StringBuilderChars
    {
        public static void Main(string[] args)
        {
            StringBuilder sb1 = new StringBuilder("abcDEF123");

            Console.WriteLine("3番目の文字:" + sb1[2]);

            //3文字目を書き換え
            sb1[2] = '!';
            Console.WriteLine("書き換え後の文字列:" + sb1);

            Console.ReadKey();
        }
    }
}
