using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class CollectionContains
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Hello", "こんにちは", "Guten Tag" };

            //要素を含むかどうか
            Console.WriteLine(list.Contains("Hello"));
            Console.WriteLine(list.Contains("おはよう"));

            Console.ReadKey();
        }
    }
}
