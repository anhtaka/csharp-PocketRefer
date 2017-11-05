using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Chap3
{
    public class DateTimeEra
    {

        public static void Main(string[] args)
        {
            //元号のリストを配列で定義
            string[] eras = { "明治", "大正", "昭和", "平成" };
            DateTime now = DateTime.Now;
            JapaneseCalendar jpn = new JapaneseCalendar();

            //指定日時の元号を取得
            int era = jpn.GetEra(now);

            //元号と年を出力
            Console.WriteLine(
                "元号: {0} {1}年",
                eras[era - 1], jpn.GetYear(now)
                );

            //日本のカルチャを作成
            CultureInfo culture = new CultureInfo("ja-JP");
            //カルチャのカレンダーを和暦に設定
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            //ToStringで元号と年を出力
            Console.WriteLine("ToStringでの出力: " + now.ToString("gg yy年", culture));
            Console.ReadKey();
        }
    }
}
