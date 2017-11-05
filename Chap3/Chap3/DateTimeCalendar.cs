using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Chap3
{
    class DateTimeCalendar
    {
        public static void Main(string[] args)
        {
            //各種暦を作成
            GregorianCalendar gre = new GregorianCalendar();
            JapaneseCalendar jpn = new JapaneseCalendar();
            JapaneseLunisolarCalendar jpnLun = new JapaneseLunisolarCalendar();
            HebrewCalendar heb = new HebrewCalendar();

            //各暦での現在の日付を表示
            WriteCalendar(gre);
            WriteCalendar(jpn);
            WriteCalendar(jpnLun);
            WriteCalendar(heb);

            Console.ReadKey();
        }

        //現在の日付を表示するメソッド
        private static void WriteCalendar(Calendar cal){
            DateTime now = DateTime.Now;
            Console.WriteLine("{0} {1}年{2}月{3}日 1年の月数:{4}",
                cal.ToString(), cal.GetYear(now),cal.GetMonth(now),
                cal.GetDayOfMonth(now),cal.GetMonthsInYear(cal.GetYear(now))
                );
        }

    }
}
