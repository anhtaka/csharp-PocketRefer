using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class FileMove
    {
        public static void Main(string[] args)
        {
            //ファイルを作成
            FileStream stream = File.Create("sample.txt");
            //FileStreamを閉じ、ファイルを保存
            stream.Close();
            //あらかじめコピー
            File.Copy("sample.txt", "sample2.txt", true);

            Directory.CreateDirectory("temp");

            //File.Moveメソッドでファイルを移動
            File.Move("sample.txt",@"temp\sample.txt");
            //FileInfo.Moveメソッドでファイルを移動
            FileInfo fileInfo = new FileInfo("sample2.txt");
            fileInfo.MoveTo(@"temp\sample2.txt");

            Console.ReadKey();
        }
    }
}
