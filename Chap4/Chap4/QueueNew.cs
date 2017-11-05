using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class QueueNew
    {
        public static void Main(string[] args)
        {
            //空のキューを作成
            Queue<string> queue1 = new Queue<string>();
            queue1.Enqueue("Hello");
            Console.WriteLine("Dequeue結果:" + queue1.Dequeue());

            //リストを作成
            List<string> list1 = new List<string>() { "Hello", "こんにちは", "Guten Tag" };

            //リストの内容をコピーしたキューを作成
            Queue<string> queue2 = new Queue<string>(list1);
            //キューに要素を追加
            queue2.Enqueue("abc");

            Console.WriteLine("foreach文で内容表示");
            //キューの内容を表示
            foreach (string s in queue2)
            {
                Console.WriteLine(s);
            }
        	Console.ReadKey();
        }
    }
}
