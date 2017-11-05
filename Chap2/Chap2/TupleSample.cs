using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2
{
    class TupleSample
    {
        static (double bmi, double ideal) BMI(float height, float weight)
        {
            height = height / 100;
            var h2 = Math.Pow(height, 2);

            // BMI値と適正体重のタプルを返す
            return (weight / h2, h2 * 22);
        }
        static void Main(string[] args)
        {
            // タプル型の定義
            (int a, int b) t1 = (1,2);
            Console.WriteLine(t1.a); // 結果：1
            
            // タプル型の定義（名前つき）
            var t2 = (a:1, b:2);
            Console.WriteLine(t2.b); // 結果：2

            // タプルで受け取る
            (var bmi, var ideal1) = BMI(170, 78);
            Console.WriteLine("{0:F2}, {1:F2} kg", bmi, ideal1);
            // 結果：26.99, 63.58 kg

            // 不要な値を_で受け取る
            (_, var ideal2) = BMI(160, 50);
            Console.WriteLine("{0:F2} kg", ideal2);
            // 結果：56.32 kg

        }

    }
}
