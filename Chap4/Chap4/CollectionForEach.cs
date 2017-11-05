using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class CollectionForEach
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Hello", "こんにちは", "Guten Tag" };

            //列挙子によるコレクションの反復処理
            IEnumerator<string> enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            } 


            //foreach文でコレクションを反復処理
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
