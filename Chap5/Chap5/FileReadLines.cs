using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class FileReadLines
    {
        public static void Main(string[] args)
        {
            // 文字列を一括書き込み
            File.WriteAllText(@"sample.txt",
                "abc\n123\nあいうえお");

            //文字列を行毎に読み込み
            IEnumerable<string> lines = File.ReadLines(@"sample.txt");

            //foreachで列挙→1行ずつ読み込みが行われる
            foreach (string s in lines)
            {
                //読み込んだ行を表示
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
