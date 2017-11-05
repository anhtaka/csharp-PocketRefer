using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class DateTimeAdd
    {
        public static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("現在日時: " + now.ToString());
            Console.WriteLine("現在日時に1年追加: " + now.AddYears(1));
            Console.WriteLine("現在日時に-20分追加: " + now.AddMinutes(-20));

            //小数点以下も考慮される
            Console.WriteLine("現在日時に3.5日追加: " + now.AddDays(3.5));

            //5時間30分0秒の日時間隔を表すTimeSpanオブジェクト
            TimeSpan span1 = new TimeSpan(5, 30, 0);

            Console.WriteLine("現在日時から5時間30分減算: "
                + now.Subtract(span1));

            //21世紀最初の日
            DateTime newMillenium = DateTime.Parse("2001/1/1");
            //DateTime同士のSubtractはTimeSpanになる
            Console.WriteLine("21世紀になってからの経過日時: "
                + now.Subtract(newMillenium));
        }
        
    }
}
