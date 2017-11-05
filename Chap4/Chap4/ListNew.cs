using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class ListNew
    {
        public static void Main(string[] args)
        {
            //初期サイズ1のリストを作成
            List<string> list1 = new List<string>(2);
            //2件追加すると、動的にサイズが変更される
            list1.Add("Hello");
            list1.Add("こんにちは");
            list1.Add("Guten Tag");

            //list1をコピーしてリストを作成
            List<string> list2 = new List<string>(list1);
            list2.Add("abc");
            Console.ReadKey();
        }
    }
}
