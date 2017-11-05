using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class DirectoryDelete
    {
        public static void Main(string[] args)
        {
            //ディレクトリを作成
            //fディレクトリを表すDirectoryInfoオブジェクトが返る
            DirectoryInfo directoryInfo = 
                Directory.CreateDirectory(@"a\b\c\d\e\f");

            //DirectoryInfoクラスのDeleteメソッドでfディレクトリを削除
            directoryInfo.Delete();

            //cディレクトリを、下の階層のディレクトリも含め再帰的に削除
            Directory.Delete(@"a\b\c", true);

            Console.ReadKey();
        }
    }
}
