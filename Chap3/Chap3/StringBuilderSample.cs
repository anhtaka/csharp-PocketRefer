using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class StringBuilderSample
    {
        public static void Main(string[] args)
        {
            //新しい文字列バッファの作成
            StringBuilder sb1 = new StringBuilder("abcDEF");
            Console.WriteLine("文字列バッファの内容:" + sb1);

            //文字列の連続追加
            sb1.Append("jkl").Append("MNO");
            //sb自体が書き換わっている
            Console.WriteLine("文字列を追加したバッファの内容:" + sb1);

            Console.ReadKey();
        }
    }
}
