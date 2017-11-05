using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class FileCopy
    {
        void Hoge(int a, int b, string c)
        {

        }

        public static void Main(string[] args)
        {
            //ファイルを作成
            FileStream stream = File.Create("sample.txt");
            //FileStreamを閉じ、ファイルを保存
            stream.Close();

            Directory.CreateDirectory("temp");
            //ファイルをコピー
            File.Copy("sample.txt", @"temp\sample.txt");
            //ファイルを上書きコピー
            File.Copy("sample.txt", @"temp\sample.txt", true);

            //sample.txtのファイル情報を作成
            FileInfo fileInfo = new FileInfo("sample.txt");
            fileInfo.CopyTo(@"temp\sample2.txt");

            Console.ReadKey();
        }
    }
}
