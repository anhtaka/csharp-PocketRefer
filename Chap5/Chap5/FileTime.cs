using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class FileTime
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"C:\Windows\の作成日時:"
                + Directory.GetCreationTime(@"C:\Windows\"));
            Console.WriteLine(@"C:\pagefile.sysの最終アクセス日時:" 
                + File.GetLastAccessTime(@"C:\pagefile.sys"));
            
            FileInfo fileInfo = new FileInfo("sample.txt");
            Console.WriteLine("sample.txtの最終更新日時:" 
                + fileInfo.LastWriteTime);

            Console.WriteLine(@"sample.txtの最終更新日時書き換え");
            //最終更新日時を2017/12/31に書き換え
            fileInfo.LastWriteTime = DateTime.Parse("2017/12/31");
            Console.WriteLine(@"sample.txtの最終更新日時:" 
                + fileInfo.LastWriteTime);

            //1099/12/31はDateTime型の範囲内
            //だがWindowsのファイルシステムではエラー発生
            try
            {
                fileInfo.LastWriteTime = DateTime.Parse("1099/12/31");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("例外発生:日付が範囲外");
            }
            Console.ReadKey();
        }
    }
}
