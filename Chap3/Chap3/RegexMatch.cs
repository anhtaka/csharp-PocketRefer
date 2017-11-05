using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Chap3
{
    class RegexMatch
    {
        public static void Main(string[] args)
        {
            string s1 = "abaabaaabaaaabbcDEF123zzz   \tzzz";

            //zで始まりzで終わるパターン
            Regex rex1 = new Regex("z.*z");
            //Matchメソッドで検索
            Match m1 = rex1.Match(s1);
            Console.WriteLine("マッチしたかどうか:{0}, マッチした部分文字列:{1}"
                , m1.Success, m1.Value);

            //b, ab, aab, aaab ,,,に対応する正規表現でマッチ箇所をまとめて検索
            Console.WriteLine("Matchesでまとめて検索検索");
            MatchCollection mc = Regex.Matches(s1, "a*b");

            //マッチした数を表示
            Console.WriteLine("マッチした数:{0}",mc.Count);

            //MatchCollectionをforeachでループ
            foreach (Match match in mc)
            {
                Console.WriteLine("MatchCollectionでのマッチ箇所:{0}"
                    , match.Value);
            }

            //同様にMatch.NextMatchメソッドでループ
            Console.WriteLine("Matchで検索後、NextMatchで次のマッチを検索");
            Match m2 = Regex.Match(s1, "a*b");
            //マッチが成功したかどうか
            while (m2.Success)
            {
                Console.WriteLine("Match.NextMatchでのマッチ箇所:{0}", m2.Value);
                m2 = m2.NextMatch();
            } 

            Console.ReadKey();
        }
    }
}
