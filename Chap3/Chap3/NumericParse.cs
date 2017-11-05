using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class NumericParse
    {
        public static void Main(string[] args)
        {
            string s1 = "12345";
            //文字列からintに変換
            int i1 = int.Parse(s1);
            Console.WriteLine("Parseでの変換成功:" + i1);

            string s2 = "hello";
            try
            {
                //数値に変換できない文字列をParse
                int i2 = int.Parse(s2);
            }
            catch (FormatException)
            {
                //例外が発生
                Console.WriteLine("Parseでの変換失敗:FormatException");
            }

            string s3 = "10000";
            int i3;
            //TryParseを使い、変換が成功したかどうかを確認
            bool result = int.TryParse(s3, out i3);
            if (result)
            {
                Console.WriteLine("TryParseでの変換成功:" + i3);
            }

            //short型の範囲を超える数値を変換
            string s4 = "65537";
            try
            {
                short sh1 = short.Parse(s4);
            }
            catch (OverflowException)
            {
                //オーバーフロー例外が発生
                Console.WriteLine("Parseでの変換失敗:OverflowException");
            }

            Console.ReadKey();
        }
    }
}
