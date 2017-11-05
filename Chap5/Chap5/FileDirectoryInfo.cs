using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class FileDirectoryInfo
    {
        public static void Main(string[] args)
        {
            //C:\Windows\explorer.exeのファイル情報を作成
            FileInfo fileInfo = new FileInfo(@"C:\Windows\explorer.exe");
            //作成日時を出力
            Console.WriteLine(@"C:\Windows\explorer.exeの作成日時:" 
                + fileInfo.CreationTime);
            
            //C:\Windowsのディレクトリ情報を作成
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Windows");
            //ディレクトリが存在するかをチェック
            Console.WriteLine(@"C:\Windowsは存在するか:" 
                + directoryInfo.Exists);

            //ディレクトリ情報からファイル一覧を取得
            Console.WriteLine("\nC:\\Windowsのファイル一覧表示");
            foreach (var file in directoryInfo.EnumerateFiles())
            {
                Console.WriteLine(file.FullName);
            }
            Console.ReadKey();
        }
    }
}
