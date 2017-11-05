using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class CollectionRemoveClear
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Hello", "こんにちは", "Guten Tag"};

            //要素を削除
            list.Remove("Hello");

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            //コレクションをクリア
            list.Clear();
            Console.WriteLine("クリア後の要素数：" + list.Count);
            Console.ReadKey();
        }
    }
}
