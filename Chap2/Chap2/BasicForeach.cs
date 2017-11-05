using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class BasicForeach
    {
        static void Main(string[] args)
        {
            // int型の配列定義
            int[] data = { 10, 15, 20 };

            foreach (int val in data)
            {
                Console.WriteLine(val);
            }

        }
    }
}
