using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    // デリゲートの宣言
    delegate int SampleDelegate2(int x);

    class DelegateAnonymous
    {
        static void Main()
        {
            // 匿名メソッドによるデリゲート
            SampleDelegate2 d = delegate(int n)
            {
                return -n;
            };                       // ;が必要

            Console.WriteLine(d(3)); // 結果:-3
        }
    }
}
