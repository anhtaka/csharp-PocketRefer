using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class CollectionMaxMin
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Hello", "こんにちは", "Guten Tag", "a" };

            //文字列の長さの最大値、最小値を計算
            Console.WriteLine("文字列長の最大値:" +
                list.Max(p => p.Length));
            Console.WriteLine("文字列長の最小値:" +
                list.Min(p => p.Length));

            Console.ReadKey();
        }
  
    }
}
