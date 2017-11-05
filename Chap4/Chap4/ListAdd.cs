using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class ListAdd
    {
        public static void Main(string[] args)
        {
            //リストに要素を追加
            List<string> list1 = new List<string>();
            list1.Add("Hello");
            list1.Add("こんにちは");
            list1.Add("Guten Tag");

            List<string> list2 = new List<string>();
            //リストにコレクションの要素をすべて追加
            list2.AddRange(list1);

            list2.Add("abc");

            foreach (string s in list2)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
