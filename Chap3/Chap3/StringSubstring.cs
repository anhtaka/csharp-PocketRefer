using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class StringSubstring
    {
        public static void Main(string[] args)
        {
            string s1 = "abcdEFG";
            //文字列の3番目の文字（インデックスは2）を取得
            Console.WriteLine(s1[2]);

            //文字列の4番目以降の部分文字列を取得
            Console.WriteLine(s1.Substring(3));

            //文字列の2番目以降3文字分の部分文字列を取得
            Console.WriteLine(s1.Substring(1,3));
            Console.ReadKey();
        }
    }
}
