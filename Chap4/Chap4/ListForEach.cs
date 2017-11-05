using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class ListForEach
    {
        public static void Main(string[] args)
        {
            List<string> list1 = new List<string>();
            list1.Add("a");
            list1.Add("b");
            list1.Add("c");
            //ForEachメソッドですべての要素を表示
            list1.ForEach(s => Console.WriteLine(s));

            //性能比較のための巨大な整数リスト
            //すべての要素を加算して比較
            List<int> list2 = new List<int>();
            for (int i = 0; i < 10000000; i++)
            {
                list2.Add(i);
            }

            DateTime statementStart = DateTime.Now;
            int sum1 = 0;

            //foreach文での処理
            foreach (int i in list2)
            {
                sum1 += i;
            }
            Console.WriteLine("foreach文の処理時間\t\t"
                + (DateTime.Now - statementStart));

            DateTime methodStart = DateTime.Now;
            int sum2 = 0;

            //ForEachメソッドでの処理
            list2.ForEach(i => sum2 += i);

            Console.WriteLine("ForEachメソッドの処理時間\t"
                + (DateTime.Now - methodStart));
            Console.ReadKey();
        }
    }
}
