using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class FileStreamNew
    {
        public static void Main(string[] args)
        {
            //書き込み用にファイルを新規作成
            FileStream stream = new FileStream(
                @"sample.txt",FileMode.Create,FileAccess.Write);
            //書き込むデータ。ASCIIコードでA,B,C
            byte[] data = new byte[]{0x41,0x42,0x43};
            //データの書き込み
            stream.Write(data, 0, data.Length);
            stream.Close();

            //読み込み用にファイルを開く
            FileStream stream2 = File.Open(
                @"sample.txt", FileMode.Open,FileAccess.Read);
            byte[] data2 = new byte[20];
            //データ読み込み
            stream2.Read(data2, 0, data2.Length);
            //読み込んだバイト列を文字列に変換
            Console.WriteLine(Encoding.ASCII.GetString(data2));

            Console.ReadKey();
        }
    }
}
