using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    // 基本クラス
    class BaseClass
    {
        public int SumValues(params int[] values)
        {
            int sum = 0;
            foreach (int v in values)
            {
                sum += v;
            }
            return sum;
        }
    }

    // BaseClassを継承した派生クラス
    class ClassInheritance : BaseClass
    {
        public void DispSumValues(params int[] values)
        {
            // SumValuesは、基本クラスから引き継いだメソッド
            Console.WriteLine(SumValues(values));
        }
        static void Main(string[] args)
        {
            ClassInheritance sum = new ClassInheritance();
            sum.DispSumValues(1, 2, 3); // 結果:6
        }
    }
}
