using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class CollectionCount
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Hello", "こんにちは", "Guten Tag" };

            //要素数を表示
            Console.WriteLine("要素数:" + list.Count);

            //要素を削除
            list.Remove("Hello");

            Console.WriteLine("削除後の要素数:" + list.Count);

            Console.ReadKey();
        }
    }
}
