using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Chap5
{
    class WebClientDownloadFile
    {
        public static void Main(string[] args)
        {
            WebClient client = new WebClient();
            //wings.htmlにダウンロード
            client.DownloadFile("http://www.wings.msn.to/",@"wings.html");
            
            //Shift-JISエンコーディングで読み込み
            IEnumerable<string> lines = File.ReadLines(
              @"wings.html", Encoding.GetEncoding("shift-jis"));
            foreach (string s in lines)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
