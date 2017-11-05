using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class CollectionConcat
    {
        public static void Main(string[] args)
        {
            List<string> list1 = new List<string>() { "Hello", "こんにちは", "Guten Tag"};
            List<string> list2 = new List<string>() { "a","b","c"};

            IEnumerable<string> list3 = list1.Concat(list2);
            foreach (string s in list3)
            {
                Console.WriteLine(s);
            }
            
            Console.ReadKey();
        }

    }
}
