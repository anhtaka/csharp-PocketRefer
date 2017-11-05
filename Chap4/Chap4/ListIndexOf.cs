using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class ListIndexOf
    {
        public static void Main(string[] args)
        {
            //リストに要素を追加
            List<string> list1 = new List<string>() { 
            "Hello","a", "こんにちは", "Guten Tag","a","b","a" };

            //前方から出現位置を検索
            Console.WriteLine(list1.IndexOf("こんにちは"));
            //3番目から3個分を検索（=2番目のaは飛ばされる）
            Console.WriteLine(list1.IndexOf("a", 3, 3));
            Console.WriteLine(list1.LastIndexOf("おはよう"));

            Console.ReadKey();
        }

    }
}
