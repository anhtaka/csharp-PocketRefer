using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class StringCompare
    {
        public static void Main(string[] args)
        {
            string s1 = "abc";
            string s2 = "123";
            Console.WriteLine("辞書順比較:" + string.Compare(s1,s2));
            Console.WriteLine("CompareToメソッドも同様:" + s1.CompareTo(s2));
            string s3 = "abc123DEF";

            Console.WriteLine("部分比較:" + string.Compare(s2,0,s3,3,3));


            Console.ReadKey();
        }
    }
}
