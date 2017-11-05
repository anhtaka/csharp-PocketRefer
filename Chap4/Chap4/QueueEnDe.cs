using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class QueueEnDe
    {
        public static void Main(string[] args)
        {
            //空のキューを作成
            Queue<string> queue1 = new Queue<string>();
            //末尾に要素を追加していく
            //要素は末尾から先頭へと進んでいく
            queue1.Enqueue("Hello");
            queue1.Enqueue("こんにちは");
            queue1.Enqueue("Guten Tag");

            //キューの内容を表示。要素に影響なし
            Console.WriteLine("foreach文で取り出し");
            foreach (string s in queue1)
            {
                Console.WriteLine(s);
            }


            //先頭から削除せず取り出す
            Console.WriteLine("最初に追加した要素をPeek:" + queue1.Peek());

            Console.WriteLine("Dequeueで取り出し");
            //要素数が0になるまで先頭から順に削除しながら取り出す
            while (queue1.Count > 0)
            {
                Console.WriteLine(queue1.Dequeue());
            }

            Console.ReadKey();
        }
    }
}
