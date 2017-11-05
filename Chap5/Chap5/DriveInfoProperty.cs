using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap5
{
    class DriveInfoProperty
    {
        public static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine("ドライブ名:" + drive.Name);
            }

            //Cドライブのドライブ情報オブジェクトを作成
            DriveInfo cdrive = new DriveInfo("c");

            Console.WriteLine("Cドライブのファイルシステム:" 
                + cdrive.DriveFormat);
            Console.WriteLine(
                "Cドライブの空き容量: {0:N}" 
                ,cdrive.TotalFreeSpace);
            Console.WriteLine(
                "Cドライブの利用可能な空き容量: {0:N}"
                ,cdrive.AvailableFreeSpace);
            Console.WriteLine(
                "Cドライブの全容量: {0:N}" , cdrive.TotalSize);

            Console.ReadKey();
        }
    }
}
