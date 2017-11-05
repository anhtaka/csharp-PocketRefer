using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class CollectionUnion
    {
        public static void Main(string[] args)
        {
            List<string> list1 = new List<string>(){"こんにちは","Guten Tag","a","b"};
            List<string> list2 = new List<string>(){"a","b","c"};

            //和集合、差集合、積集合を計算
            IEnumerable<string> union = list1.Union(list2);
            IEnumerable<string> except = list1.Except(list2);
            IEnumerable<string> intersect = list1.Intersect(list2);

            //string.Joinメソッドでコレクション内を,で連結して出力
            Console.WriteLine("Union:" + string.Join(",", union));
            Console.WriteLine("Except:" + string.Join(",",except ));
            Console.WriteLine("Intersect:" + string.Join(",",intersect ));

            Console.ReadKey();
        }
    }
}
