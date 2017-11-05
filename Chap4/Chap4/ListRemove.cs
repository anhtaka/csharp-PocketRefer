using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class ListRemove
    {
        public static void Main(string[] args)
        {
            //リストに要素を追加
            List<string> list1 = new List<string>() {
                "Hello", "こんにちは", "Guten Tag","a","b","c","d","e","f" };

            //最初の要素を削除
            list1.RemoveAt(0);
            //2番目から4つの要素を削除
            list1.RemoveRange(2, 4);

            Console.WriteLine("RemoveRange後：");
            foreach (string str in list1)
            {
                Console.WriteLine(str);
            }

            //長さ3文字以内の要素をすべて削除
            int result = list1.RemoveAll(p => p.Length <= 3);

            Console.WriteLine("RemoveAllで削除した個数：{0}",result);
            Console.WriteLine("RemoveAll後：");
            foreach (string str in list1)
            {
                Console.WriteLine(str);
            }


            Console.ReadKey();
        }
    }
}
