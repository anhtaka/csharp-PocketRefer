using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class FileExists
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("File , Directoryクラス");
            Console.WriteLine(@"C:\Windows\は存在するか:" 
                + Directory.Exists(@"C:\Windows"));
            Console.WriteLine(@"C:\Windows\explorer.exeは存在するか:"
                + File.Exists(@"C:\Windows\explorer.exe"));

            Console.WriteLine("FileInfo , DirectoryInfoクラス");
            //C:\a\b\c\d\eのディレクトリ情報を作成
            DirectoryInfo directoryInfo = new DirectoryInfo(@"a\b\c\d\e");
            //ディレクトリが存在するかをチェック
            Console.WriteLine(@"a\b\c\d\eは存在するか:"
                + directoryInfo.Exists);
            FileInfo fileInfo = new FileInfo(@"C:\Windows\explorer.exe");
            Console.WriteLine(@"C:\Windows\explorer.exeは存在するか:"
                + fileInfo.Exists);


            Console.ReadKey();
        }
    }
}
