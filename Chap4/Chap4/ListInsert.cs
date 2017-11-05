using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class ListInsert
    {
        public static void Main(string[] args)
        {
            List<string> list1 = new List<string>() { "Hello", "こんにちは", "Guten Tag" };

            //最初に要素を挿入
            list1.Insert(0, "おはよう");

            List<string> list2 = new List<string>() { "a", "b", "c" };

            //コレクションを挿入
            list1.InsertRange(1, list2);

            foreach (string s in list1)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
