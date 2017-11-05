using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class HashSetNew
    {
        public static void Main(string[] args)
        {
            //空のセットを生成
            HashSet<string> hashSet1 = new HashSet<string>();
            //要素を追加
            hashSet1.Add("abc");
            //同じ要素を追加しても無視される
            hashSet1.Add("abc");

            List<string> list1 = new List<string>(){"Hello","こんにちは","Guten Tag"};

            //リストの要素をコピーしたセットを生成
            HashSet<string> linkedList2 = new HashSet<string>(list1);
            Console.WriteLine("リスト中の要素を含むか:" 
                + linkedList2.Contains("こんにちは"));

            Console.ReadKey();
        }
    }
}
