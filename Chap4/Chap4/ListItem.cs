using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class ListItem
    {
        public static void Main(string[] args)
        {
            List<string> list1 = new List<string>() { "Hello", "こんにちは", "Guten Tag" };

            Console.WriteLine("1番目の要素:" + list1[0]);
            //3番目の要素を書き換え
            list1[2] = "abc";

            //4番目の要素は無いため例外発生
            list1[3] = "zzz";

            Console.ReadKey();
        }
    }
}
