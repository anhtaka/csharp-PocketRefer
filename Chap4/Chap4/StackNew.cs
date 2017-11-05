using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class StackNew
    {
        public static void Main(string[] args)
        {
            //空のスタックを作成
            Stack<string> stack1 = new Stack<string>();
            //スタックに値をプッシュ、ポップ
            stack1.Push("Hello");
            Console.WriteLine("Pop結果:" + stack1.Pop());

            //リストを作成
            List<string> list1 = new List<string>() { "Hello", "こんにちは", "Guten Tag" };

            //リストの内容をコピーしたスタックを作成
            Stack<string> stack2 = new Stack<string>(list1);
            //スタックに要素を追加
            stack2.Push("abc");

            Console.WriteLine("foreach文で内容表示");
            //スタックの内容を表示
            foreach (string s in stack2)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
