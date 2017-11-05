using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    delegate void Action1<in T>(T obj); // 反変性
    interface ISample<out T> { }        // 共変性

    class DelegateVar
    {
        class Base { }
        class Sub : Base { }
        class Im : ISample<Sub> { }

        static void Main()
        {
            Action1<object> d1 = n => { };
            Action1<string> d2 = d1;
            // stringからobjectの変換はコンパイル不可
            // d3 = d4;

            ISample<Sub> s = new Im();
            ISample<Base> b = s;
            // BaseらSubの変換はコンパイル不可
            // s = b;
        }
    }
}
