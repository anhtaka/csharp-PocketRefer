using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class StringRemove
    {
        public static void Main(string[] args)
        {
            string s1 = "abcDEF123";

            //3文字目から3文字削除
            Console.WriteLine(s1.Remove(2, 3));

            Console.ReadKey();
        }
    }
}
