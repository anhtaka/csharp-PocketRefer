using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class CollectionWhere
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Hello", "こんにちは", "Guten Tag", "a" };

            //文字列の長さが3文字以上の要素だけを抽出
            IEnumerable<string> where = list.Where(p => p.Length >= 3);
            Console.WriteLine("3文字以上の要素:");
            foreach (string s in where)
            {
                Console.WriteLine(s);
            }

            //リスト内のインデックスが2未満の要素だけを抽出
            IEnumerable<string> where2 = list.Where((p,index) => index < 2);
            Console.WriteLine("インデックス2未満の要素:");
            foreach (string s in where2)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
