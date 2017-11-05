using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Chap5
{
    class ReaderRead
    {
        public static void Main(string[] args)
        {
            Main2(args).Wait();
        }

        public static async Task Main2(string[] args)
        {
            //読み込み対象文字列
            string source = "あいうえお\nabc\nかきくけこ";
            
            //文字列リーダー作成
            StringReader reader = new StringReader(source);

            char c;
            //改行コード（\n）まで1文字ずつ読み込む
            do{
                //1文字読み込み。Readの戻り値はintなのでcharにキャスト
                c = (char)reader.Read();
                Console.WriteLine("1文字読み込み:" + c);
            }while(c != '\n');

            Console.WriteLine("1行読み込み:" + reader.ReadLine());

            Console.WriteLine("末尾まで読み込み:" + reader.ReadToEnd());

            //Console.WriteLine("1行読み込み(非同期版):" + await reader.ReadLineAsync());

            //Console.WriteLine("末尾まで読み込み(非同期版):" + await reader.ReadToEndAsync());


            Console.ReadKey();
        }
    }
}
