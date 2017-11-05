using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Chap3
{
    class StringToUpLow
    {
        public static void Main(string[] args)
        {
            //半角全角アルファベット
            string s1 = "abcDEFghiＪＫＬｍｎｏ";

            //大文字化、小文字化
            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s1.ToLower());

            //トルコ語での大文字化
            CultureInfo tr = new CultureInfo("tr-TR");
            //トルコ語でのiの大文字化は日本語環境では文字化け
            Console.WriteLine(s1.ToUpper(tr));

            //インバリアント カルチャで大文字化
            Console.WriteLine(s1.ToUpperInvariant());

            Console.ReadKey();
        }

    }
}
