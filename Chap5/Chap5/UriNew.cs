using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5
{
    class UriNew
    {
        public static void Main(string[] args)
        {
            //HTTPのURI作成
            Uri uri = new Uri("http://www.wings.msn.to");
            //FTPのURIも作成可能
            Uri uri2 = new Uri("ftp://ftpServer");

            string escaped = Uri.EscapeDataString("あいうえお");
            Console.WriteLine("あいうえおをURIエスケープ:" + escaped);
            Console.WriteLine("URIエスケープ解除:" 
                + Uri.UnescapeDataString(escaped));

            //Google検索用のURIをエスケープ
            string uri3 = "http://www.google.co.jp/search?q=クエリ";
            Console.WriteLine("エスケープされたURI:" 
                + Uri.EscapeUriString(uri3));
            //URIをEscapeDataStringすると壊れる
            Console.WriteLine("URIをEscapeDataString:"
                + Uri.EscapeDataString(uri3));

            Console.ReadKey();
        }
    }
}
