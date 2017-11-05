using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class BasicVar
    {
        static void Main(string[] args)
        {
            const float PI = 3.14159f;
            const int CELSIUS = 273;

            var i = 123;                 // int型
            var str = "Sampl";           // string
            var a = new[] { 0, 1, 2 };   // 配列
            var list = new List<int>();  // int型のList

            Console.WriteLine(PI);
            Console.WriteLine(CELSIUS);
            Console.WriteLine(i);
            Console.WriteLine(str);
         }

        class BasicReadonly
        {
            readonly int val;

            BasicReadonly(int arg)
            {
                this.val = arg;
            }

            void method()
            {
                // エラーとなる
                // val= 123;
            }
        }
    }
}
