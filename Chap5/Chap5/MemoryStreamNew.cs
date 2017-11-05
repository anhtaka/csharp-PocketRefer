using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class MemoryStreamNew
    {
        public static void Main(string[] args)
        {
            //メモリストリームの作成
            MemoryStream stream = new MemoryStream();
            byte[] data = Encoding.Unicode.GetBytes("こんにちはabc");
            //ストリームに書き込み
            stream.Write(data, 0, data.Length);
            //先頭から2バイト目にシーク(=「ん」の位置)
            stream.Seek(2, SeekOrigin.Begin);
            //読み込み用バッファ
            byte[] data2 = new byte[20];
            //ストリームから読み込み
            stream.Read(data2, 0, data2.Length);
            Console.WriteLine("ストリームに書き込んだデータ:" 
                + Encoding.Unicode.GetString(data2));

            //バッファを取得
            byte[] data3 = stream.GetBuffer();
            Console.WriteLine("内部バッファの内容:"
                + Encoding.Unicode.GetString(data3));


            Console.ReadKey();
        }
    }
}
