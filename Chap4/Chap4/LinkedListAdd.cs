using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class LinkedListAdd
    {
        public static void Main(string[] args)
        {
            //空の二重リンクリストを生成
            LinkedList<string> linkedList1 = new LinkedList<string>();
            //要素を追加
            linkedList1.AddFirst("HelloHello");
            linkedList1.AddFirst("こんにちは");
            linkedList1.AddFirst("Guten Tag");

            //最初の要素を取得
            LinkedListNode<string> node = linkedList1.First;
            linkedList1.AddFirst("AddFirst");
            linkedList1.AddBefore(node, "AddBefore");
            linkedList1.AddAfter(node, "AddAfter");
            linkedList1.AddLast("AddLast");

            //順に表示
            foreach (string s in linkedList1)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }

    }
}
