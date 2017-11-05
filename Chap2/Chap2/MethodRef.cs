using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2
{
    class MethodRef
    {
        static void Main(string[] args)
        {
            var ary = new int[] { 1, 2, 3 };

            Console.WriteLine(string.Join(",", ary)); // 1,2,3
            ref int a0 = ref SetValue(ary);           // a0は、ary[0]の参照
            a0 = ary[2];                              // ary[0]を書き換えている
            Console.WriteLine(string.Join(",", ary)); // 3,2,3
            int a = SetValue(ary);                    // aはary「0」の値のコピー  
            a = 10;                                   // ary[0]には反映されない
            Console.WriteLine(string.Join(",", ary)); // 5,2,3

        }

        static ref int SetValue(int[] ary)
        {
            ary[0] = 5;
            return ref ary[0]; // 引数の配列の参照先を返す
        }

    }
}
