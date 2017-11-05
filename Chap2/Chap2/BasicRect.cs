using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class BasicRect
    {
        static void Main(string[] args)
        {
            // 2次元配列（四角配列）
            int[,] matrix = { { 1, 2 }, { 3, 4 } };

            for (int i = 0; i < 2; i++)
                Console.WriteLine("{0},{1}", matrix[i, 0], matrix[i, 1]);

            // 要素として配列を2つ持つ配列
            int[][] jagArray = new int[2][];
            jagArray[0] = new int[] { 1, 2 };
            jagArray[1] = new int[] { 1, 2, 3 };

            for (int i = 0; i < 2; i++)
                Console.WriteLine("{0},{1},{2}",
                    jagArray[i][0], jagArray[i][1], (i > 0) ? jagArray[i][2] : -1);
        }
    }
}
