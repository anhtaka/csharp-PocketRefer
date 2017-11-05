using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class StringBuilderInsert
    {
        public static void Main(string[] args)
        {
            //新しい文字列バッファの作成
            StringBuilder sb1 = new StringBuilder("abcDEF");
            //2文字目に数値を挿入
            sb1.Insert(1,1234.56);
            Console.WriteLine("数値の挿入:" + sb1);

            //文字列を先頭に複数回挿入
            sb1.Insert(0,"あいう", 3);
            Console.WriteLine("文字列の挿入:" + sb1);

            //DateTimeを先頭に挿入
            sb1.Insert(0, DateTime.Now);

            Console.WriteLine("オブジェクトの挿入:" + sb1);
            Console.ReadKey();
        }
    }
}
