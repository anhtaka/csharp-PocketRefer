using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Chap5
{
    class WriterWrite
    {
        public static void Main(string[] args)
        {
            Main2(args).Wait();
        }

        public static async Task Main2(string[] args)
        {
            StreamWriter writer = new StreamWriter(@"sample.txt");
            //数値書き込み
            writer.Write(123);

            //文字列書き込み（非同期版）
            //await writer.WriteAsync("123");

            //改行文字書き込み
            writer.WriteLine();

            //改行文字書き込み（非同期版）
            //await writer.WriteLineAsync();

            //オブジェクト（日時型）書き込み
            writer.Write(DateTime.Now);

            //バッファをフラッシュ
            writer.Flush();
            //ライターを閉じる
            writer.Close();

            //ライターの書き込み内容を取得
            string text = File.ReadAllText(@"sample.txt");

            Console.WriteLine("ライターに書き込んだ内容:" + text);
            Console.ReadKey();
        }
    }
}
