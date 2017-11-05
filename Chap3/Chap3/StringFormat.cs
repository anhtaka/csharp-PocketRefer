using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Chap3
{
    class StringFormat
    {
        public static void Main(string[] args)
        {
            int i1 = 12345678;
            double percent1 = 0.2432;
            double d1 = 12345.678901234;
            DateTime now = DateTime.Now;
            string s1 = "あいうえお";

            //3つのオブジェクトを{0},{1},{2}に埋め込み
            Console.WriteLine(string.Format(
                "複数のオブジェクト埋め込み {0},{1},{2}",s1,i1,now));
            //s1を{0}で2回参照
            Console.WriteLine(string.Format(
                "同じオブジェクトを複数回指定可能 {0},{1},{0}",s1,i1));

            //数値:標準
            Console.WriteLine(string.Format("数値デフォルト:{0}",i1));
            Console.WriteLine(string.Format("数値10進表記:{0:D}", i1));
            Console.WriteLine(string.Format("数値全般表記:{0:G}", i1));
            Console.WriteLine(string.Format("数値桁区切り表記:{0:N}", i1));
            Console.WriteLine(string.Format("数値パーセント表記:{0:P}", percent1));
            Console.WriteLine(string.Format("数値16進表記8桁右詰め:{0:X8}",i1));
            Console.WriteLine(string.Format("数値指数表記:{0:E}",d1));
            Console.WriteLine(string.Format(
                "数値固定小数点表記小数点4桁:{0:F4}", d1));

            //数値:通貨。デフォルトは日本カルチャで\表記3桁区切り
            Console.WriteLine(string.Format("数値通貨表記:{0:C}", i1));
            //en-US（米国）カルチャでの表記。$表記3桁区切り
            Console.WriteLine(string.Format(
                new CultureInfo("en-US"), "数値通貨表記 en-US:{0:C}", i1));
            //hi-IN（インド）カルチャでの表記。,区切りがかなり特殊
            Console.WriteLine(string.Format(
                new CultureInfo("hi-IN"), "数値通貨表記 hi-IN:{0:C}", i1));

            //alignment指定
            Console.WriteLine(string.Format(
                "数値10進表記15桁右詰め:{0,15:D}", i1));
            //alignmentの方が必要桁数より小さい場合は無視される
            Console.WriteLine(string.Format("数値10進表記5桁:{0,5:D}", i1));

            int i2 = 123;
            //数値:カスタム
            Console.WriteLine(string.Format("数値0詰め5桁:{0:00000}", i2));
            Console.WriteLine(string.Format(
                "数値小数表記カスタム指定:{0:###.###}", d1));
            Console.WriteLine(string.Format("数値桁区切り指定:{0:#,#}", i1));

            //日時
            Console.WriteLine(string.Format("日付長い形式:{0:D}", now));
            Console.WriteLine(string.Format(
                "日付カスタム形式:{0:yyyy/MM/dd hh:mm:ss}", now));
            
            Console.ReadKey();
        }
    }
}
