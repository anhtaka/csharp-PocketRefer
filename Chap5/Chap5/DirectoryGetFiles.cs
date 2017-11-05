using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class DirectoryGetFiles
    {
        public static void Main(string[] args)
        {
            string[] fileNames = Directory.GetFiles(@"C:\");
            Console.WriteLine(@"C:\にあるファイル数 : " + fileNames.Length);

            //対象はChap5ディレクトリ
            DirectoryInfo directoryInfo = 
                new DirectoryInfo(@"..\..\");

            FileInfo[] aspxFiles = directoryInfo.GetFiles("*.cs");
            Console.WriteLine(
                @"Chap5にある*.csファイルの数 : "
                + aspxFiles.Length);
            FileInfo[] allTxtFiles = directoryInfo.GetFiles(
                "*.txt",SearchOption.AllDirectories);
            Console.WriteLine(
                @"Chap5以下にあるすべての*.txtファイルの数 : "
                + allTxtFiles.Length);

            Console.ReadKey();
        }
    }
}
