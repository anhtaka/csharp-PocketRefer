using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class StringBuilderCapacity
    {
        public static void Main(string[] args)
        {
            StringBuilder sb0 = new StringBuilder();
            Console.WriteLine("既定のCapacity:" + sb0.Capacity);
            //バッファサイズを縮小
            sb0.Capacity = 2;

            StringBuilder sb1 = new StringBuilder("abcDEF123abcDEF123");

            Console.WriteLine("初期文字列を格納できるCapacity:" + sb1.Capacity);
            Console.WriteLine("MaxCapacity:" + sb1.MaxCapacity);
            //100文字追加
            sb1.Append('a', 100);
            //バッファサイズが自動拡大
            Console.WriteLine("自動拡大したCapacity:" + sb1.Capacity);


            //Capacity:10, MaxCapacity:20で文字列バッファ作成
            StringBuilder sb2 = new StringBuilder(10,20);
            try
            {
                //バッファサイズを超えて追加
                sb2.Append('a', 21);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("ArgumentOutOfRangeException例外発生");
            }
            
            Console.ReadKey();
        }
    }
}
