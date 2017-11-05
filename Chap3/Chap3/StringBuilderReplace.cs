using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class StringBuilderReplace
    {
        public static void Main(string[] args)
        {
            //新しい文字列バッファの作成
            StringBuilder sb1 = new StringBuilder("abcDEFghiZZZ123abc");

            //文字単位の複数回置換。
            sb1.Replace('Z', 'y');
            Console.WriteLine("文字置換:" + sb1);

            //文字列単位の複数回置換。異なる長さの文字列で置換
            sb1.Replace("abc", "あいうえお",3,15);
            Console.WriteLine("4文字目から15文字分を文字列置換:" + sb1);
            Console.ReadKey();
        }

    }
}
