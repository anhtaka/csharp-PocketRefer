using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class StackPushPop
    {
        public static void Main(string[] args)
        {
            Stack<int> stack1 = new Stack<int>();
            //スタックに値をプッシュ
            stack1.Push(1);
            stack1.Push(2);
            Console.WriteLine("先頭の要素をPeek:" + stack1.Peek());
            Console.WriteLine("先頭の要素をPop:" + stack1.Pop());
            Console.WriteLine("次の要素をPop:" + stack1.Pop());

            Console.ReadKey();
        }
    }
}
