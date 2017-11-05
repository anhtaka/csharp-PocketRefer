using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class LinkedListFirstLast
    {
        public static void Main(string[] args)
        {
            //空の二重リンクリストを生成
            LinkedList<string> linkedList1 = new LinkedList<string>();
            //要素を追加
            linkedList1.AddFirst("abc");
            linkedList1.AddFirst("HelloHello");
            linkedList1.AddFirst("こんにちは");
            linkedList1.AddFirst("Guten Tag");

            //最初の要素を取得
            LinkedListNode<string> node = linkedList1.First;
            //Nextプロパティを使って順にノードを処理
            while (node != null)
            {
                //要素の内容を表示
                Console.WriteLine(node.Value);
                //次の要素を取得
                node = node.Next;
            }

            Console.ReadKey();
        }

    }
}
