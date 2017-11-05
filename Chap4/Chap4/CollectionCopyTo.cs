using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class CollectionCopyTo
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Hello", "こんにちは", "Guten Tag" };

            //サイズ5の配列
            string[] array = new string[5]{
                "a","b","c","d","e"
            };

            //配列の2要素目からコピー
            list.CopyTo(array, 1);

            //foreach文で配列内を表示
            foreach (string s in array)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
