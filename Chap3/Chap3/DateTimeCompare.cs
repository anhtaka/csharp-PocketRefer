using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class DateTimeCompare
    {
        public static void Main(string[] args)
        {
            DateTime t1 = DateTime.Parse("2011/4/1");
            DateTime t2 = DateTime.Parse("2012/8/1");

            //Compareメソッドでの比較 t1の方が前なので負の値
            Console.WriteLine("t1とt2の比較結果: {0}", DateTime.Compare(t1, t2));

            //演算子でも比較可能
            if (t1 < t2)
            {
                Console.WriteLine("t1の方が前の日時");
            }
        }

    }
}
