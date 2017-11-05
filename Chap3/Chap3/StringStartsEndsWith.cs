using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class StringStartsEndsWith
    {
        public static void Main(string[] args)
        {
            string s1 = "abcDEFghi123-999";

            //指定文字列で始まるか、終わるか
            Console.WriteLine("StartsWith:" + s1.StartsWith("abc"));
            Console.WriteLine("EndsWith:" + s1.EndsWith("999"));

            Console.ReadKey();
        }
    }
}
