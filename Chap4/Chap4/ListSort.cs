using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class ListSort
    {
        public static void Main(string[] args)
        {
            List<string> list1 = new List<string>();
            list1.Add("HelloHello");
            list1.Add("こんにちは");
            list1.Add("Guten Tag");
            list1.Add("a");
            list1.Add("b123");

            //ソート条件は文字列の長さで比較する関数
            //ここでは2つの数値を比較する、int型のCompareToメソッドを使用
            list1.Sort((x, y) => x.Length.CompareTo(y.Length));
            foreach (string s in list1)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
