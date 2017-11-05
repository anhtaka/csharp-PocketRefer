using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class BasicCast
    {
        static void Main(string[] args)
        {
            float x = 1f;
            long y = 2;
            int z = 3;

            y = z;        // long型←int型の拡張変換
            x = y;        // float型←long型の拡張変換

            int a = 123;
            long b = a;
            // short c = a;      // コンパイルエラー
            short d = (short)a;  // キャストすればOK

            int xx = 123456789;
            float yy = xx;            // 拡張変換なのでエラーにならない
            decimal zz = (decimal)yy;

            Console.WriteLine(xx); // 結果：123456789
            Console.WriteLine(yy); // 結果：1.234568E+08
            Console.WriteLine(zz); // 結果：123456800
        }
    }
}
