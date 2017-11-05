using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class ClassRef
    {
        // aを３倍して表示する
        public void Triple(ref int a)
        {
            a *= 3;
            Console.WriteLine(a);
        }
        static void Main()
        {
            int a = 5;                    // 初期化が必要
            new ClassRef().Triple(ref a);  // 出力値：15

            Console.WriteLine(a);         // 出力値：15
        }
    }
}
