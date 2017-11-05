using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Chap5
{
    class FileStreamWrite
    {
        public static void Main(string[] args)
        {
            Main2(args).Wait();
        }

        public static async Task Main2(string[] args)
        {
            //書き込み用にファイルを開く
            FileStream stream = File.Open(
                @"sample.txt", FileMode.Create, FileAccess.Write);

            //書き込むデータ。ASCIIコードでA,B,C
            byte[] data = new byte[] { 0x41, 0x42, 0x43 };
            //バイト列の書き込み
            stream.Write(data, 0, data.Length);

            //バイト列の書き込み（非同期版）
            //await stream.WriteAsync(data, 0, data.Length);

            //1バイト書き込み。ASCIIコードでD
            stream.WriteByte(0x44);
            stream.Close();

            //書き込んだ内容を読み込み
            FileStream stream2 = File.OpenRead(@"sample.txt");
            byte[] data2 = new byte[20];
            stream2.Read(data2, 0, data2.Length);

            // 読み込んだバイト列を文字列に変換
            Console.WriteLine(Encoding.ASCII.GetString(data2));

            Console.ReadKey();
        }
    }
}
