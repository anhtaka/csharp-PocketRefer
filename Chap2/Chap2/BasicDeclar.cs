using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class BasicDeclar
    {
        static void Main(string[] args)
        {
            int a, b, c;          // int型変数の宣言
            ushort d = 5;         // 初期値の設定
            double pi = 3.14159;  // double型変数の宣言
            char x = 'A';         // 文字型変数の宣言

            Console.WriteLine(d);
            Console.WriteLine(pi);
            Console.WriteLine(x);
            a = b = c = 0;
            Console.WriteLine(c);
        }
    }
}
