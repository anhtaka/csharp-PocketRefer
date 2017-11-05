using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class StringConcat
    {
        public static void Main(string[] args)
        {
            string s1 = "abc";
            string s2 = "defg";

            //文字列の連結
            Console.WriteLine(string.Concat(s1,s2));


            DateTime d1 = DateTime.Now;
            int i1 = 64;
            //日時情報と数値の連結
            //両方ともObjectとして扱われ、ToStringメソッドの結果が連結される
            Console.WriteLine(string.Concat(d1,i1));

            //+演算子で連結
            Console.WriteLine(
                s1 + s2 + d1 + i1
                );
            Console.ReadKey();
        }
    }
}
