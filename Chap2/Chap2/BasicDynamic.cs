using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class BasicDynamic_sub
    {
        // objはどんな型でもコンパイル可能
        public void Sample(dynamic obj)
        {
            // obj型にMethodが含まれるかどうかは
            // 実行時に検査される
            obj.Method();
        }
    }

    class BasicDynamic
    {
        public void Method()
        {
        }

        static void Main(string[] args)
        {
            var tmp1 = 1;           // int型
            dynamic tmp2 = 1;       // dynamic型
            Console.WriteLine(tmp1);

            var cls1 = new BasicDynamic();
            var cls2 = new BasicDynamic_sub();

            cls2.Sample(cls1);
            
            // コンパイル可能だが、実行時に例外が発生する
            cls2.Sample(cls2);
        }
    }
}
