using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace Chap5
{
    class WebClientDownloadData
    {
        public static void Main(string[] args)
        {
            Main2(args).Wait();
        }

        public static async Task Main2(string[] args)
        {
            WebClient client = new WebClient();
            //Webサーバーからデータをダウンロード
            byte[] data = client.DownloadData("http://www.wings.msn.to/");
            //byte[] data = await client.DownloadDataTaskAsync("http://www.wings.msn.to/");

            //Shift-JISエンコーディングで文字列化
            string content = Encoding.GetEncoding("shift-jis").GetString(data);

            //先頭300文字を出力
            Console.WriteLine(
                "http://www.wings.msn.to/から取得したデータ: \n{0}"
                ,content.Substring(0,300));

            Console.ReadKey();
        }
    }
}
