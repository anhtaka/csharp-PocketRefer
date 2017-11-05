using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class StringIndexOf
    {
        public static void Main(string[] args)
        {
            string s1 = "abcDEFghi123-999";

            Console.WriteLine("文字列で検索:" + s1.IndexOf("123"));
            Console.WriteLine("文字で検索:" + s1.IndexOf('E'));

            Console.WriteLine("4文字目以降で検索:" + s1.IndexOf("abc", 3));
            Console.WriteLine("6文字目以降から5文字の範囲を検索:"
                + s1.IndexOf('F',5,5));

            Console.WriteLine("先頭から9を検索:" + s1.IndexOf('9'));
            Console.WriteLine("末尾から9を検索:" + s1.LastIndexOf('9'));

            Console.WriteLine("1-5いずれかの出現位置:"
                + s1.IndexOfAny(new char[]{'1','2','3','4','5'}));
            Console.ReadKey();
        }
    }
}
