using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class BasicIf2
    {
        static void Main(string[] args)
        {
            string str = "テスト文字列"; // この例では、あり、長が表示される

            if (str == null)
            {
                Console.WriteLine("なし");
            }
            else if (str.Length > 1)
            {
                Console.WriteLine("あり");

                if (str.Length > 5)
                {
                    Console.WriteLine("長");
                }
            }
            else
                Console.WriteLine("処理しない");
        }
    }
}
