using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class CDefault<T>
    {
        public T Tmp()
        {
            return default(T);
        }
    }
    class ClassDefault
    {
        static void Main()
        {
            Console.WriteLine(
                new CDefault<int>().Tmp());            // 出力値：0

            Console.WriteLine(
                new CDefault<string>().Tmp() == null); // 出力値：True
        }
    }
}
