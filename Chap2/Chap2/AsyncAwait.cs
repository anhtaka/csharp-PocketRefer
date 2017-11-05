using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

namespace Chap2
{
    class AsyncAwait
    {
        static void Main(string[] args)
        {
            Task t1 = GetWebAsync("http://www.msn.com/");
            Console.WriteLine("end");
            // "end" の出力後に非同期に実行されたGetWebAsyncの結果が表示される
            Thread.Sleep(5000);
        }
        static async Task GetWebAsync(string url) // 非同期メソッド
        {
            using (var client = new HttpClient())
            {
                string c = await client.GetStringAsync(url);
                Console.WriteLine(url + " " + c.Length);
            }
        }
    }
}
