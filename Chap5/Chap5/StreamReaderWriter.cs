using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class StreamReaderWriter
    {
        public static void Main(string[] args)
        {
            //メモリストリーム作成
            FileStream stream = File.OpenWrite(@"sample.txt");
            //ストリームライター作成
            StreamWriter writer = new StreamWriter(stream);
            //ライターに書き込み
            writer.WriteLine("あいうえお");
            writer.Write("abc");
            writer.Close();

            //コンストラクタでリーダー作成
            StreamReader reader = new StreamReader(@"sample.txt");
            //リーダーから読み込んで出力
            Console.WriteLine("new StreamReaderで読み込み:" + reader.ReadToEnd());
            //File.OpenTextメソッドでリーダー作成
            StreamReader reader2 = File.OpenText(@"sample.txt");
            Console.WriteLine("File.OpenTextで読み込み:" + reader2.ReadToEnd());

            Console.ReadKey();
        }
    }
}
