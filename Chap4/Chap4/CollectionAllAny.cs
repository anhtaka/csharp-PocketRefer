using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class CollectionAllAny
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>() { "HelloHello", "こんにちは", "Guten Tag","a" };

            //すべての要素について、文字数が3以上かどうか
            System.Console.WriteLine(
                list.All(p => p.Length >= 3));

            //いずれかの要素で、文字数が1のものがあるかどうか
            System.Console.WriteLine(
                list.Any(p => p.Length == 1));

            Console.ReadKey();
        }

    }
}
