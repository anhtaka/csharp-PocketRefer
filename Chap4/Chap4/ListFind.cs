using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class ListFind
    {
        public static void Main(string[] args)
        {
            //リストに要素を追加
            List<string> list1 = new List<string>() { 
              "Hello","こんにちは", "Guten Tag","a","b","a","こんにちはabcde" };

            Console.WriteLine("文字列長10以上の要素:" +
                list1.Find(p => p.Length >= 10));

            List<string> findAll = list1.FindAll(p => p.Length < 3);
            Console.WriteLine("文字列長3未満の要素:" + 
                string.Join(",",findAll));

            Console.WriteLine("aの出現位置（前方から検索）:" + 
                list1.FindIndex(p => p == "a"));

            Console.WriteLine("aの出現位置（後方から検索）:" + 
                list1.FindLastIndex(p => p == "a"));

            Console.ReadKey();
        }
    }
}
