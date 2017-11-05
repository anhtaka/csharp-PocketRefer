using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Chap3
{
    class RegexOptionsSample
    {
        public static void Main(string[] args)
        {
            string s1 = "abaab\naaabaaaabbcDEF123zzz   \tzzz";

            //先頭のaを検索
            Regex rex1 = new Regex("^a");
            MatchCollection m1 = rex1.Matches(s1);
            Console.WriteLine("通常モードでのマッチ数:" + m1.Count);
            //複数行モードで^aが改行後のaにもヒットするように
            Regex rex2 = new Regex("^a",RegexOptions.Multiline);
            MatchCollection m2 = rex2.Matches(s1);
            Console.WriteLine("複数行モードでのマッチ数:" + m2.Count);

            //大文字小文字無視
            Match m3 = Regex.Match(s1, "def", RegexOptions.IgnoreCase);
            Console.WriteLine("大文字小文字無視でのマッチ箇所:" + m3.Value);

            //Aで始まりFで終わるパターン
            Regex rex3 = new Regex("A.*F"
                //RegexOptionsは|で複数まとめて指定可能
                //単一行モードかつ大文字小文字無視
                , RegexOptions.Singleline | RegexOptions.IgnoreCase);
            Match m4 = rex3.Match(s1);
            Console.WriteLine("複数オプションでのマッチ箇所:" + m4.Value);
            Console.ReadKey();
        }
    }
}
