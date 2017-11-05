using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class StringJoin
    {
        public static void Main(string[] args)
        {
            //文字列配列
            string[] strings = new string[]{
                "abc","DEF","123","999"
            };
            //,（カンマ）を挟んで連結
            Console.WriteLine(string.Join(",",strings));

            //文字列のリスト
            var list = new List<string>()
            {
                "aaa","BBB","xyz"
            };
            //separatorにnullを指定したので単純に文字列連結
            Console.WriteLine(string.Join(null,list));

            Console.ReadKey();
        }
    }
}
