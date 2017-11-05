using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class ClassStatic
    {
        // staticメソッド
        static void print()
        {
            Console.WriteLine("staticメソッド");
        }
        static void Main(string[] args)
        {
            // クラス名.メソッド名でアクセスできる
            ClassStatic.print();
        }
    }
}
