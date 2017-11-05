using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class StreamSeek
    {
        public static void Main(string[] args)
        {
            //メモリストリームの作成
            MemoryStream stream = new MemoryStream();

            //1文字2バイトのUnicodeエンコーディングで読み書き
            byte[] data = Encoding.Unicode.GetBytes("こんにちはabc");
            //ストリームに書き込み
            stream.Write(data, 0, data.Length);

            //先頭から4バイト目にシーク(=「に」の位置)
            stream.Seek(4, SeekOrigin.Begin);
            //読み込み用バッファ
            byte[] data2 = new byte[20];
            //ストリームから読み込み
            stream.Read(data2, 0, 20);
            Console.WriteLine("先頭から4バイト目以降:"
                + Encoding.Unicode.GetString(data2));

            //末尾から6バイト戻った位置にシーク(=「a」の位置)
            stream.Seek(-6, SeekOrigin.End);
            byte[] abc = new byte[6];
            //6バイト読み込み
            stream.Read(abc, 0, 6);
            Console.WriteLine("末尾から6バイト分:" 
                + Encoding.Unicode.GetString(abc));



            Console.ReadKey();
        }

    }
}
