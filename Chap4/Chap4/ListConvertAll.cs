using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class ListConvertAll
    {
        public static void Main(string[] args)
        {
            //リストに要素を追加
            List<int> list1 = new List<int>() { 3, 5, 10 };

            //intからstringに変換する
            //変換にはStringBuilderのAppendメソッドを使い、
            //"."を指定回数分並べた文字列を生成
            List<string> list2 = list1.ConvertAll(
                p => new StringBuilder().Append('.', p).ToString());

            foreach (string s in list2)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }

    }
}
