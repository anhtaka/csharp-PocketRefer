using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    // 基本クラス
    class BaseClass4
    {
        public virtual void SampleMethod(int n)
        {
            Console.WriteLine(n);
        }
    }
    class ClassOverride : BaseClass4
    {

        // オーバーライド
        public override void SampleMethod(int n)
        {
            Console.WriteLine(n*2);
        }

        static void Main()
        {
            var c = new ClassOverride();
            c.SampleMethod(10); // 結果:20
        }
    }
}
