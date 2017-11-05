using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    public class NumericMinMax
    {

        public static void Main(string[] args)
        {
            int i1 = int.MaxValue;

            //int.MaxValueの値は2147483647
            Console.WriteLine("int.MaxValue: " + i1);

            //int.MaxValueからさらにインクリメント
            i1 = i1 + 1;

            //Int32型の範囲を超えるため、結果は一周して-2147483648に
            Console.WriteLine("int.MaxValue + 1 ?: " + i1);

            //checkedキーワードを付け、オーバーフローを検出
            checked
            {
                try
                {
                    byte b1 = byte.MinValue;
                    //MinValueからさらにデクリメント
                    b1--;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("checkedキーワードによりbyte型オーバーフローを検出");
                }
            }
            Console.ReadKey();
        }
    }
}
