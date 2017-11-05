using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class StringBuilderAppend
    {
        public static void Main(string[] args)
        {
            //新しい文字列バッファの作成
            StringBuilder sb1 = new StringBuilder("abcDEF");
            //文字列の追加
            sb1.Append("zzz");
            
            //文字を複数回追加
            sb1.Append('.',3);

            //doubleを追加
            sb1.Append(123.456);

            //改行付きで文字列を追加
            sb1.AppendLine("Hello!");

            //書式に沿ってオブジェクトを埋め込んで追加
            sb1.AppendFormat("現在日時: {0}", DateTime.Now);

            Console.WriteLine("文字列バッファの内容:" + sb1);


            Console.ReadKey();
        }
    }
}
