using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class FileDelete
    {
        public static void Main(string[] args)
        {
            //ファイルを作成
            FileStream stream = File.Create("sample.txt");
            //FileStreamを閉じ、ファイルを保存
            stream.Close();
            //あらかじめコピー
            File.Copy("sample.txt", "sample2.txt", true);

            //File.Deleteメソッドでファイルを削除
            File.Delete("sample.txt");
            //FileInfo.Deleteメソッドでファイルを削除
            FileInfo fileInfo = new FileInfo("sample2.txt");
            fileInfo.Delete();

            Console.ReadKey();
        }
    }
}
