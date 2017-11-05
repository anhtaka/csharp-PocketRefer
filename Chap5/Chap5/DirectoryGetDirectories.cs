using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class DirectoryGetDirectories
    {
        public static void Main(string[] args)
        {
            string[] dirNames = Directory.GetDirectories(@"C:\");
            Console.WriteLine(@"C:\にあるディレクトリ数 : " + dirNames.Length);

            //対象はC:\
            DirectoryInfo directoryInfo =
                new DirectoryInfo(@"C:\");

            //Programで始まるディレクトリを取得
            DirectoryInfo[] dirs = directoryInfo.GetDirectories("Program*");
            Console.WriteLine(
                @"C:\にあるProgram*のディレクトリの数 : " + dirs.Length);

            //C:\のファイルとディレクトリすべてを取得
            FileSystemInfo[] allFileAndDirs = directoryInfo.GetFileSystemInfos();
            Console.WriteLine(
                @"C:\にあるすべてのファイルとディレクトリの数 : "
                + allFileAndDirs.Length);

            Console.ReadKey();
        }
    }
}
