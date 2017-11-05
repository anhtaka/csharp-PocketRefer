using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class StringInsert
    {
        public static void Main(string[] args)
        {
            string s1 = "abcDEF";

            //3文字目に文字列を挿入
            Console.WriteLine(s1.Insert(2, "999"));

            Console.ReadKey();
        }
    }
}
