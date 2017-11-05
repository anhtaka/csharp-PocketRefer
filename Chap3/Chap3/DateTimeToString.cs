using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Chap3
{
    public class DateTimeToString
    {
        public static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            //既定のカルチャ情報で文字列化
            Console.WriteLine("既定のカルチャでToString : " 
                + d1.ToString());

            //en-US(英語-アメリカ合衆国)のカルチャ情報で文字列化
            Console.WriteLine("en-USカルチャでToString : " 
                + d1.ToString(new CultureInfo("en-US")));

            //既定のカルチャ情報でToLongDateString
            Console.WriteLine("既定のカルチャでToLongDateString : " 
                + d1.ToLongDateString());

            //en-US(英語-アメリカ合衆国)のカルチャ情報で短い日付書式
            Console.WriteLine("en-USカルチャで短い日付書式 : " 
                + d1.ToString("D", new CultureInfo("en-US")));

            //カスタムの書式で文字列化
            Console.WriteLine("カスタムの書式でToString : " 
                + d1.ToString("yyyy-MM-dd dddd hh時mm分ss秒"));
            Console.ReadKey();
        }


    }
}
