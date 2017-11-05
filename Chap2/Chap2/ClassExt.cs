using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    public static class StringExtender
    {
        // 拡張メソッド(16進文字列を数値型に変換)
        public static int Hex2Int(this string s)
        {
            return Convert.ToInt32(s, 16);
        }
    }
    class ClassExt
    {
        static void Main()
        {
            string s = "CD";
            Console.WriteLine(s.Hex2Int()); // 出力値：205
        }
    }
}
