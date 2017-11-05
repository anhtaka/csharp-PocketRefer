using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class ClassParams
    {
        // 合計求めるメソッド
        public　int SumValues( params int[] values )
        {
            int sum = 0;

            foreach (int v in values)
            {
                sum += v;
            }
            return sum;
        }


        static void Main(string[] args)
        {
            ClassParams sum = new ClassParams();
            Console.WriteLine(sum.SumValues(1, 2));
            Console.WriteLine(sum.SumValues(1, 2, 5, 10));
        }
    }
}
