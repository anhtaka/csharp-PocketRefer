using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class StringTrim
    {
        public static void Main(string[] args)
        {
            //半角/全角スペース、タブ、改行を含む文字列
            string s1 = " \t　abcDEF   \n";

            Console.WriteLine("前後を削除:" + s1.Trim());
            Console.WriteLine("先頭を削除:" +s1.TrimStart());

            string s2 = "...  abcDEF;  ;;;....";
            Console.WriteLine("先頭のピリオドを削除:" + s2.TrimStart('.'));
            Console.WriteLine("末尾のピリオドとセミコロンを削除:" + s2.TrimEnd('.',';'));

            Console.ReadKey();
        }
    }
}
