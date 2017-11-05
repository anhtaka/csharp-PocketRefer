using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class StringSplit
    {
        public static void Main(string[] args)
        {
            string s1 = "abcZdefZZZZ123Z";
            //'Z'で分割
            string [] results1 = s1.Split(new char[]{'Z'});
            //分割結果をスペースとカンマで挟んで表示
            Console.WriteLine(string.Join(" , " , results1));

            //空の文字列を結果から除去
            string[] results2 = s1.Split(
                new char[] { 'Z' },StringSplitOptions.RemoveEmptyEntries);
            //結果から空文字列が消える
            Console.WriteLine(string.Join(" , ", results2));

            //ZZで分割
            string[] results3 = s1.Split(
                new string[] { "ZZ" }, StringSplitOptions.None);
            Console.WriteLine(string.Join(" , ", results3));

            string s2 = "abc\tdef GHI\njkl";
            //何も指定しないので、空白文字で分割
            string[] results4 = s2.Split();
            Console.WriteLine(string.Join(" , ", results4));
            
            Console.ReadKey();

        }

    }
}
