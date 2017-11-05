using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class DirectoryMove
    {
        public static void Main(string[] args)
        {
            //ディレクトリを作成
            DirectoryInfo directoryInfo =
                Directory.CreateDirectory(@"a\b\c");

            //cディレクトリをtemp\cに移動
            //temp\と指定すると例外が発生するので注意
            directoryInfo.MoveTo(@"temp\c");

            //aディレクトリをtemp\aに移動
            Directory.Move(@"a", @"temp\a");
            //temp\aをtemp\bに名前変更
            Directory.Move(@"temp\a", @"temp\b");

            //C:\temp\のディレクトリ一覧を表示
            foreach (string file in Directory.EnumerateDirectories(@"temp\"))
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}
