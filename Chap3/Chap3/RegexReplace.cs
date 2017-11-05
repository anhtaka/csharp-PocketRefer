using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Chap3
{
    class RegexReplace
    {
        public static void Main(string[] args)
        {
            string s1 = "abcDEF123zzz   \tzzz";

            //zで始まりzで終わるパターン
            Regex rex1 = new Regex("z.*z");
            //Replaceメソッドで置換
            string m1 = rex1.Replace(s1,"zz");
            Console.WriteLine("置換結果:" + m1);

            //時間を hh:mm:ssから hh時mm分ss秒に変換
            string s2 = "20:12:20";
            //時、分、秒の数値をグループ名を付けてパターン指定
            Regex time = new Regex(
                "(?<hour>\\d{2}):(?<minute>\\d{2}):(?<second>\\d{2})");
            //置換後の文字列では${}で各グループを参照
            string timeReplacePattern = "${hour}時${minute}分${second}秒";
            string m2 = time.Replace(s2, timeReplacePattern);
            Console.WriteLine("グループによる置換結果:" + m2);

            //大文字小文字混じりのメールアドレスを小文字に変換したい
            //ただしメールアドレス以外の部分はそのままにしたい
            string s3 = "Doi Tsuyoshi <DoiDoi@Sample.COM>";
            //グループ名付き正規表現
            Regex email = new Regex(
              "(?<account>[a-zA-Z0-9]*)@(?<domain>[a-zA-Z0-9.]+\\.[a-zA-Z0-9]+)");
            //マッチ部分を小文字化するMailToLowerメソッドを
            //呼び出すデリゲートを指定
            string m3 = email.Replace(s3,new MatchEvaluator(MailToLower));
            Console.WriteLine("MatchEvaluatorによる置換結果:" + m3);

            Console.ReadKey();
        }

        static string MailToLower(Match m)
        {
            //マッチした文字列を小文字化
            return m.Value.ToLower();
        }
    }
}
