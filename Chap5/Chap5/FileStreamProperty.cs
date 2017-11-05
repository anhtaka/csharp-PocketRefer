using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class FileStreamProperty
    {
        public static void Main(string[] args)
        {
            //読み込み用にファイルを開く
            FileStream stream = new FileStream(
                @"sample.txt", FileMode.Open, FileAccess.Read);
            Console.WriteLine("読み込み用ファイルストリーム");
            Console.WriteLine("CanRead:" + stream.CanRead);
            Console.WriteLine("CanWrite:" + stream.CanWrite);
            Console.WriteLine("CanSeek:" + stream.CanSeek);
            Console.WriteLine("Length:" + stream.Length);
            Console.WriteLine("Position:" + stream.Position);
            stream.Close();

            FileStream stream2 = File.OpenWrite(@"sample2.txt");
            Console.WriteLine("書き込み用ファイルストリーム");
            Console.WriteLine("CanRead:" + stream2.CanRead);
            Console.WriteLine("CanWrite:" + stream2.CanWrite);
            stream2.Close();

            Console.ReadKey();
        }
    }
}
