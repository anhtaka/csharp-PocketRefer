using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class StringReaderWriter
    {
        public static void Main(string[] args)
        {
            //読み込み対象文字列
            string source = "あいうえお";
            //文字列リーダー作成
            StringReader reader = new StringReader(source);
            Console.WriteLine(
                "文字列リーダーから読み込んだ内容:" + reader.ReadToEnd());

            //書き込み対象StringBuilder
            StringBuilder sb = new StringBuilder();
            //あらかじめStringBuilderに書き込んでおく
            sb.Append("abc");
            //StringBuilderを元に文字列ライターを作成
            StringWriter writer = new StringWriter(sb);
            //文字列ライターに書き込み
            writer.Write("あいうえお123");

            //内容出力。あらかじめStringBuilderに書き込んだ内容も含む
            Console.WriteLine(
                "文字列ライターに書き込んだ内容:" + writer.ToString());

            Console.ReadKey();
        }

    }
}
