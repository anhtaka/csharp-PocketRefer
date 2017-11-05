using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    // 基本クラス
    sealed class BaseClass3
    {
    }
    // エラーとなってコンパイル不可
//    class Class13 : BaseClass3
//    {
//

    class BaseClass3_2
    {
        public virtual void M()
        {
        }
    }
    class C : BaseClass3_2
    {
        sealed override public void M()
        {
            Console.WriteLine("M2");
        }
    }
    class D : C
    {
        // エラーとなってコンパイル不可
//        override public void M()
//        {
//            Console.WriteLine("M2");
//        }
    }
}
