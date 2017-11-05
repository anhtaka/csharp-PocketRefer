using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class DirectoryCreate
    {
        public static void Main(string[] args)
        {
            //CreateDirectoryメソッドでディレクトリ作成
            DirectoryInfo directoryInfo =
                Directory.CreateDirectory(@"temp\a");

            //Createメソッドでディレクトリ作成
            DirectoryInfo directoryInfo2 = new DirectoryInfo(@"temp\b");
            directoryInfo2.Create();
            Console.ReadKey();
        }
    }
}
