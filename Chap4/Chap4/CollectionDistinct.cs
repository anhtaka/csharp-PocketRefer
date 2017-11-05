using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class CollectionDistinct
    {
        public static void Main(string[] args)
        {
            //重複有りリスト
            List<string> stringList1 = new List<string>(){
                "a","b","c","a","a","b","z"};

            //重複を除去
            IEnumerable<string> distinct = stringList1.Distinct();
            foreach (string s in distinct)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }

    }
}
