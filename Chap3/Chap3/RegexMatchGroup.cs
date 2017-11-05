using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Chap3
{
    class RegexMatchGroup
    {
        public static void Main(string[] args)
        {
            string s1 = "hogehoge@sample.com";
            //簡易版のメールアドレス正規表現
            //小文字アルファベットと数字で構成。@の後ろはピリオドを挟むこと
            //@の前と後を()で囲んでグループ化
            Regex email1 = new Regex("([a-z0-9]*)@([a-z0-9.]+\\.[a-z0-9]+)");
            Match m1 = email1.Match(s1);
            //各グループの内容を取得
            foreach (Group group in m1.Groups)
            {
                Console.WriteLine("グループの位置:{0},文字列:{1}"
                    ,group.Index,group.Value);
            }

            //グループ名付き正規表現
            Regex email2 = new Regex(
                "(?<account>[a-z0-9]*)@(?<domain>[a-z0-9.]+\\.[a-z0-9]+)");
            Match m2 = email2.Match(s1);
            //account, domainグループを取得
            Group accountGroup = m2.Groups["account"];
            Group domainGroup = m2.Groups["domain"];
            Console.WriteLine("アカウント:{0},ドメイン:{1}"
                , accountGroup.Value, domainGroup.Value);

            Console.ReadKey();
        }
    }
}
