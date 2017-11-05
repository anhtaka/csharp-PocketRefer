using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class ClassNullable
    {
        static void Main()
        {
            // nullの代入可能
            int? x = null;

            if (!x.HasValue) // 値がないなら
            {
                Console.WriteLine(x == null);  // 出力：True
            }

            x = 5;
            if (x.HasValue) // 値があれば
            {
                Console.WriteLine(x.Value);   // 出力：5
            }
        }
    }
}
