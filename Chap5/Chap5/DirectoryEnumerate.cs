using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class DirectoryEnumerate
    {
        public static void Main(string[] args)
        {
            IEnumerable<string> dirNames = Directory.EnumerateDirectories(@"C:\");
            Console.WriteLine(@"C:\にあるディレクトリ一覧");
            foreach (string name in dirNames)
            {
                Console.WriteLine(name);
            }

            //対象はC:\Users\
            DirectoryInfo directoryInfo =
                new DirectoryInfo(@"C:\Windows\Media");

            Console.WriteLine(@"C:\Windows\MediaにあるWindows*のファイル一覧");
            //Windows*で始まるファイル一覧を取得
            IEnumerable<FileInfo> infos = directoryInfo.EnumerateFiles(
                "Windows*",SearchOption.AllDirectories);
            foreach (FileInfo info in infos)
            {
                Console.WriteLine(info.Name);
            }

            Console.ReadKey();
        }
    }
}
