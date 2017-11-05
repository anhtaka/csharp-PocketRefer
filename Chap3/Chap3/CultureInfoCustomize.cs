using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Chap3
{
    class CultureInfoCustomize
    {
        public static void Main(string[] args)
        {
            CultureInfo current = CultureInfo.CurrentCulture;
            //カルチャ情報は読み取り専用の部分があるため、Cloneメソッドでコピー
            CultureInfo culture = (CultureInfo)current.Clone();
            NumberFormatInfo numberFormatInfo = culture.NumberFormat;
            DateTimeFormatInfo dateTimeFormatInfo = culture.DateTimeFormat;
            Console.WriteLine("現在のカルチャ名:" + culture.Name);
            Console.WriteLine(
                "通貨記号:{0}\n数値の桁区切り文字:{1}"
                , numberFormatInfo.CurrencySymbol
                , numberFormatInfo.NumberGroupSeparator);
            Console.WriteLine(
                "数値の桁区切りの桁数:{0}\n日時書式:{1}"
                , numberFormatInfo.NumberGroupSizes[0]
                , dateTimeFormatInfo.FullDateTimePattern);

            int i1 = 123456789;

            Console.WriteLine("デフォルトカルチャ");
            //数値:通貨。\表記3桁区切り
            Console.WriteLine(string.Format("数値通貨表記:{0:C}", i1));
            //日付は年月日
            Console.WriteLine(string.Format("日付表記:{0:F}", DateTime.Now));

            Console.WriteLine("カスタマイズしたカルチャ");
            //日時書式の変更
            culture.DateTimeFormat.FullDateTimePattern = "yyyy/MM/dd hh:mm";
            //桁区切りを4桁毎に変更
            culture.NumberFormat.CurrencySymbol = "￥";
            culture.NumberFormat.CurrencyGroupSizes = new int[] { 4 };
            //桁区切り文字を、に変更
            culture.NumberFormat.CurrencyGroupSeparator = "、";

            //カスタマイズした通貨書式
            Console.WriteLine(string.Format(culture,"数値通貨表記:{0:C}", i1));
            //カスタマイズした日時書式
            Console.WriteLine(string.Format(
                culture,"日付表記:{0:F}", DateTime.Now));

            Console.ReadKey();
        }
    }
}
