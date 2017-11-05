using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace Chap5
{
    class WebClientDownloadString
    {
        public static void Main(string[] args)
        {
            Main2(args).Wait();
        }

        public static async Task Main2(string[] args)
        {
            WebClient client = new WebClient();
            Console.WriteLine(
                "デフォルトのエンコーディング:" + client.Encoding.EncodingName);
            string str = client.DownloadString("http://www.wings.msn.to/");

            //テキストのダウンロード（非同期版）
            //string str = await client.DownloadStringTaskAsync("http://www.wings.msn.to/");

            //先頭300文字を出力
            Console.WriteLine(
                "http://www.wings.msn.to/から取得したデータ: \n{0}"
                , str.Substring(0, 300));
            Console.ReadKey();
        }
    }
}
