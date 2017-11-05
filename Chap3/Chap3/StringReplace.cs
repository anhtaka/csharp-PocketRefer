using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class StringReplace
    {
        public static void Main(string[] args)
        {
            string s1 = "abcDEFghiZZZ123abc";

            //文字単位の置換
            Console.WriteLine(s1.Replace('Z', 'y'));

            //文字列単位の置換
            Console.WriteLine(s1.Replace("abc","あいうえお"));
            Console.ReadKey();
        }
    }
}
