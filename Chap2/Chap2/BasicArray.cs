using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class BasicArray
    {
        static void Main(string[] args)
        {
            int[] array1;           // 宣言のみ
            array1 = new int[5];    // 実体の生成

            // いずれも同じ内容の配列
            int[] array2 = new int[] { 2, 4, 6 };
            int[] array3 = { 2, 4, 6 };
            var array4 = new[] { 2, 4, 6 };

            array1[0] = 5;

            Console.WriteLine(array2[2] + array1[0]); // 結果:11
            Console.WriteLine(array4[2]); // 結果:6
        }
    }
}
