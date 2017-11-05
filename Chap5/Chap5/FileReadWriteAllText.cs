using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class FileReadWriteAllText
    {
        public static void Main(string[] args)
        {
            //文字列を一括書き込み
            File.WriteAllText(@"sample.txt",
                "abc\n123\nあいうえお");
            //文字列を一括読み込み
            string data = File.ReadAllText(@"sample.txt");
            Console.WriteLine("ReadAllTextの内容:" + data);

            string[] lines = {"ABC","999","こんにちは"};
            //文字列配列を一括書き込み。エンコーディングはShift-JIS
            File.WriteAllLines(
              @"sample2.txt", lines, Encoding.GetEncoding("shift-jis"));
            //文字列配列を一括読み込み。エンコーディングはShift-JIS
            string[] data2 = File.ReadAllLines(
              @"sample2.txt", Encoding.GetEncoding("shift-jis"));
            //読み込んだデータを行毎に,で挟んで出力
            Console.WriteLine("ReadAllLinesの内容:" + string.Join(",",data2));

            Console.ReadKey();
        }
    }
}
