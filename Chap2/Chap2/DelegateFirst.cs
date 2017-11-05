using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    // デリゲートの宣言
    delegate void SampleDelegate(int x);

    class DelegateFirst
    {
        static void Reverse(int n)
        {
            Console.Write(-n);
        }
        static void Double(int n)
        {
            Console.Write(n * 2);
        }
        void Triple(int n)
        {
            Console.Write(n * 3);
        }
        static void Main()
        {
            // デリゲート型変数の宣言とメソッドの登録
            // SampleDelegate d = new SampleDelegate(Reverse)の省略形
            SampleDelegate d = Reverse;
            d(3); // 結果:-3

            d = Double;
            d(3); // 結果:6

            // 複数メソッドの登録
            d += Reverse;
            d(3); // 結果:6-3

            // インスタンスメソッドを登録する例
            d = new DelegateFirst().Triple;
            d(3); // 結果:9
        }
    }
}
