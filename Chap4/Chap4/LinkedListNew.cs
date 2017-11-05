using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class LinkedListNew
    {
        public static void Main(string[] args)
        {
            //空の二重リンクリストを生成
            LinkedList<string> linkedList1 = new LinkedList<string>();
            //要素を追加
            linkedList1.AddFirst("abc");

            List<string> list1 = new List<string>();
            list1.Add("HelloHello");
            list1.Add("こんにちは");
            list1.Add("Guten Tag");

            //リストの要素をコピーした二重リンクリストを生成
            LinkedList<string> linkedList2 = new LinkedList<string>(list1);
            //内容を表示
            foreach (string s in linkedList2)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
