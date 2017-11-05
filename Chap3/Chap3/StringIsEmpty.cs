using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class StringIsEmpty
    {
        public static void Main(string[] args)
        {
            //空文字列
            string s1 = "";
            Console.WriteLine("IsNullOrEmpty:" + string.IsNullOrEmpty(s1));

            //null
            string s2 = null;
            Console.WriteLine("IsNullOrEmpty:" + string.IsNullOrEmpty(s2));

            //半角スペース、全角スペース、タブ、改行
            string s3 = " \t　\n";
            Console.WriteLine("IsNullOrWhiteSpace" + string.IsNullOrWhiteSpace(s3));
            Console.ReadKey();
        }
    }
}
