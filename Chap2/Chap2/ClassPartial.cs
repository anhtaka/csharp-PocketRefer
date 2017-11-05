using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    partial class ClassPartial
    {
        int a = 3;
    }
    partial class ClassPartial
    {
        public void Test() { Console.WriteLine(this.a); }
    }
    partial class ClassPartial
    {
        static void Main()
        {
            new ClassPartial().Test(); // 結果：3
        }
    }
}
