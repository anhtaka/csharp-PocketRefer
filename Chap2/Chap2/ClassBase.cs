using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    // 基本クラス
    class BaseClass2
    {
        public BaseClass2(string s)
        {
            Console.WriteLine(s);
        }
    }
    class ClassBase : BaseClass2
    {
        // baseキーワードで、パラメータを指定
        public ClassBase(string s1, string s2)
            : base(s2)
        {
            Console.WriteLine(s1);
        }
        static void Main()
        {
            var c = new ClassBase("Derived", "Base");
            // 実行結果は以下の出力となる
            // Base
            // Derived
        }
    }
}
