using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class HashSetSubSuper
    {
        public static void Main(string[] args)
        {
            List<string> list1 = new List<string>() { "HelloHello", "こんにちは", "Guten Tag" };

            HashSet<string> set = new HashSet<string>();
            set.Add("Hello");
            set.Add("こんにちは");

            Console.WriteLine("サブセットか：" + set.IsSubsetOf(list1));
            Console.WriteLine("スーパーセットか：" + set.IsSupersetOf(list1));
            Console.WriteLine("共通の要素を持つか：" + set.Overlaps(list1));

            Console.ReadKey();
        }
    }
}
