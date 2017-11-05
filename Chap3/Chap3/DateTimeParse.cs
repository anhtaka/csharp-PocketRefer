using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Chap3
{
    public class DateTimeParse
    {
        public static void Main(string[] args)
        {
            //標準的なyyyy/MM/ddの書式
            string s1 = "2011/10/10";
            DateTime d1;
            //TryParseメソッドを使って解析
            bool ret = DateTime.TryParse(s1, out d1);
            if (ret)
                Console.WriteLine("TryParse結果 " + d1);

            //英語圏で一般的な書式
            string s2 = "6/1/2009 4:37:00 PM";
            //en-US(英語-アメリカ合衆国)のカルチャ情報付きで解析
            DateTime d2 = DateTime.Parse(s2, new CultureInfo("en-US"));
            Console.WriteLine("カルチャ付きParse結果 " + d2);

            //カスタムの書式例：日時情報をすべて数値で連結
            string s3 = "201102031025";
            //カスタムの書式を解析。カルチャは指定せず
            //DateTimeStyles.Noneは既定の解析オプションを表す
            DateTime d3 = DateTime.ParseExact(s3, "yyyyMMddhhmm", null, DateTimeStyles.None);
            Console.WriteLine("カスタムの変換結果 " + d3);
            Console.ReadKey();
        }


    }
}
