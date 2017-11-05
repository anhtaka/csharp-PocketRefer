using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class CollectionAverageSum
    {
        public static void Main(string[] args)
        {
            List<string> stringList = new List<string>() { "Hello", "こんにちは", "Guten Tag", "a"};

            //文字列の長さの平均値、合計値を計算
            Console.WriteLine("文字列長の平均値:" + 
                stringList.Average(p => p.Length));
            Console.WriteLine("文字列長の合計値:" +
                stringList.Sum(p => p.Length)); 

            Console.ReadKey();
        }
    }
}
