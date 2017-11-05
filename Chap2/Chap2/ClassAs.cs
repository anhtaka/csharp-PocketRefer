using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class ClassAs : Sample
    {
        public static void Main()
        {
            var c1 = new ClassAs();
            object c2 = c1 as Sample;      // 変換可能
            object c3 = (Sample)c1;        // 変換可能

            object c4 = c2 as string;      // 変換不可
            Console.WriteLine(c4 == null); // 結果：True

            // 実行時に例外発生
            object c5 = (string)c2;
        }
    }
}
