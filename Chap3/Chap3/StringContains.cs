using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class StringContains
    {
        public static void Main(string[] args)
        {
            string s1 = "abcDEFghi";
            //文字列を含むか
            Console.WriteLine(s1.Contains("abc"));

            //文字単位での検索
            Console.WriteLine(s1.Contains('a'));

            //検索は大文字小文字を区別
            Console.WriteLine(s1.Contains("def"));
            Console.ReadKey();
        }
    }
}
