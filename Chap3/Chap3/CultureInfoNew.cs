using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Chap3
{
    class CultureInfoNew
    {
        public static void Main(string[] args)
        {
            CultureInfo current = CultureInfo.CurrentCulture;
            int i1 = 123456;
            Console.WriteLine("現在のカルチャ名:" + current.Name);

            //日本カルチャでの表記
            //数値:通貨。\表記3桁区切り
            Console.WriteLine(string.Format("数値通貨表記:{0:C}", i1));
            //日付は年月日
            Console.WriteLine(string.Format("日付表記:{0:D}\n", DateTime.Now));

            //en-US（米国）カルチャでの表記
            CultureInfo enUs = new CultureInfo("en-US");
            Console.WriteLine("カルチャ名:" + enUs.Name);
            //通貨は$表記3桁区切り
            Console.WriteLine(string.Format(
                enUs, "数値通貨表記:{0:C}", i1));
            //日付は曜日、月名、日、年の順
            Console.WriteLine(string.Format(enUs,"日付表記:{0:D}\n", DateTime.Now));

            //ru-RU（ロシア）カルチャでの表記
            CultureInfo ruRu = new CultureInfo("ru-RU");
            Console.WriteLine("カルチャ名:" + ruRu.Name);
            //通貨は$表記3桁区切り
            Console.WriteLine(string.Format(
                ruRu, "数値通貨表記:{0:C}", i1));
            //日付は曜日、月名、日、年の順
            Console.WriteLine(string.Format(ruRu, "日付表記:{0:D}\n", DateTime.Now));

            //hi-IN（インド）カルチャでの表記。
            CultureInfo hiIn = new CultureInfo("hi-IN");
            Console.WriteLine("カルチャ名:" + hiIn.Name);
            //通貨は桁区切りがかなり特殊
            Console.WriteLine(string.Format(
                hiIn, "数値通貨表記:{0:C}", i1));
            //日付も異なる
            Console.WriteLine(string.Format(
                hiIn, "日付表記:{0:D}", DateTime.Now));
            Console.ReadKey();


        }
    }
}
