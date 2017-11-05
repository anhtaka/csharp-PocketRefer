using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Chap5
{
    class FileStreamCopyTo
    {
        public static void Main(string[] args)
        {
            Main2(args).Wait();
        }

        public static async Task Main2(string[] args)
        {
            //読み込み用ファイルストリーム
            FileStream stream = File.OpenRead(@"sample.txt");
            //書き込み用ファイルストリーム
            FileStream stream2 = File.OpenWrite(@"sample2.txt");

            //先頭からストリームをコピー(=ファイルのコピー)
            stream.CopyTo(stream2);

            //先頭からストリームをコピー(=ファイルのコピー) (非同期版)
            //await stream.CopyToAsync(stream2);

            stream2.Close();
            stream.Close();

            Console.ReadKey();
        }
    }
}
