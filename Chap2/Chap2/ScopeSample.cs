using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class ScopeSample
    {
        int val = 0;                     // スコープはScopeSampleクラス内

        public void Sample()
        {
            int val = 1;                 // スコープはSampleメソッド内
            Console.WriteLine(val);      // 結果：1
            Console.WriteLine(this.val); // 結果：0

        }
        static void Main()
        {
            new ScopeSample().Sample();
        }
    }
}
