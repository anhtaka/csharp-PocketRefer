using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class StringBuilderRemove
    {
        public static void Main(string[] args)
        {
            StringBuilder sb1 = new StringBuilder("abcDEF123");

            Console.WriteLine("削除前の容量:" + sb1.Capacity);
            //3文字目から3文字削除
            sb1.Remove(2, 3);
            Console.WriteLine("削除後の文字列:" + sb1);

            //文字列の長さが変わっても容量には変化無し
            Console.WriteLine("削除後の容量:" + sb1.Capacity);

            Console.ReadKey();
        }
    }
}
