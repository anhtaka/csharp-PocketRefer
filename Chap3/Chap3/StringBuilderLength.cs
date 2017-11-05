using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class StringBuilderLength
    {
        public static void Main(string[] args)
        {
            StringBuilder sb1 = new StringBuilder("abcDEF123");

            Console.WriteLine("文字列の長さ:" + sb1.Length);

            //文字列長を短くする
            sb1.Length = 3;
            Console.WriteLine("切り詰め後の文字列:{0} , 長さ:{1}", sb1, sb1.Length);

            //文字列長を長くする
            sb1.Length = 6;
            Console.WriteLine("拡張後の文字列:{0} , 長さ:{1}", sb1, sb1.Length);

            Console.ReadKey();
        }
    }
}
