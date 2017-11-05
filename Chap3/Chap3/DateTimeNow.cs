using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Chap3
{
    public class DateTimeNow
    {
        public static void Main(string[] args)
        {
            //Nowプロパティから現在日時を取得
            DateTime now = DateTime.Now;

            //年月日の表示
            Console.WriteLine(
                "{0}年{1}月{2}日{3}",
                now.Year, now.Month, now.Day, now.DayOfWeek);

            //時刻の表示
            Console.WriteLine(
                "{0}時{1}分{2}秒{3}ミリ秒",
                now.Hour, now.Minute, now.Second, now.Millisecond);

            Console.WriteLine(
                "年初から{0}日目 0001/1/1 0:00からの経過時間:{1}",
                now.DayOfYear, now.Ticks
                );
            Console.ReadKey();
        }


    }
}
