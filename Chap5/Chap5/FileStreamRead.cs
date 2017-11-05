using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Chap5
{
    class FileStreamRead
    {
        public static void Main(string[] args)
        {
            Main2(args).Wait();
        }

        public static async Task Main2(string[] args)
        {
            //読み込み用にファイルを開く
            FileStream stream = File.Open(
                @"C:\windows\notepad.exe", FileMode.Open, FileAccess.Read);

            byte[] data = new byte[10];

            //20バイト読み込み
            stream.Read(data, 0, 10);

            //20バイト読み込み（非同期版）
            //await stream.ReadAsync(data, 0, 10);

            //読み込んだバイト列を文字列に変換して出力
            Console.WriteLine("notepad.exeの先頭10バイト:" + BitConverter.ToString(data));

            int b;
            do
            {
                //1バイト読み込み
                //b = stream.ReadByte();
                b = stream.ReadByte();
            } while (b != -1); //末尾に到達するまでループ

            Console.ReadKey();
        }
    }
}
