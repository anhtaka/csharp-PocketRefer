using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class FileReadWriteAll
    {
        public static void Main(string[] args)
        {

            //書き込むデータ。ASCIIコードでA,B,C,D
            byte[] data = new byte[] { 0x41, 0x42, 0x43, 0x44 };

            //一括書き込み
            File.WriteAllBytes(@"sample2.txt", data);

            //一括読み込み
            byte[] data2 = File.ReadAllBytes(@"sample2.txt");

            Console.WriteLine("読み込んだデータ量:" + data.Length);

            // 読み込んだバイト列を文字列に変換
            Console.WriteLine(Encoding.ASCII.GetString(data2));

            Console.ReadKey();
        }
    }
}
