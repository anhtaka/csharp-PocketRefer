using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class FileCreate
    {
        public static void Main(string[] args)
        {
            //ファイルを作成
            FileStream stream = File.Create("sample.txt");
            //FileStreamを閉じ、ファイルを保存
            stream.Close();

            FileInfo fileInfo = new FileInfo("sample2.txt");
            FileStream stream2 = fileInfo.Create();
            //FileStreamを閉じ、ファイルを保存
            stream.Close();

            Console.ReadKey();
        }
    }
}
