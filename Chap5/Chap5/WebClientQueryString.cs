using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Chap5
{
    class WebClientQueryString
    {
        public static void Main(string[] args)
        {
            WebClient client = new WebClient();
            //GoogleのWeb検索を行う例
            //qというキーに値（検索文字列）を設定
            client.QueryString["q"] = "WINGS";
            //QueryStringプロパティが付加される
            //実際には"http://www.google.co.jp/search?q=WINGS"にアクセス
            string str = client.DownloadString("http://www.google.co.jp/search");
            //先頭300文字を出力
            Console.WriteLine(str.Substring(0,300));
            
            Console.ReadKey();
        }
    }
}
