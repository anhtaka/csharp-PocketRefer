using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class SampleGeneric
    {
        public int Value { get; set; }
    }

    // 型パラメータは、SampleGenericまたはその派生クラスのみ
    class GenericClassSub<T> where T : SampleGeneric
    {
        public int Sample(T t)
        {
            return t.Value;
        }
    }
    class ClassGsample2
    {
        static void Main()
        {
            var s = new SampleGeneric();
            var gc = new GenericClassSub<SampleGeneric>();

            s.Value = 123;
            Console.WriteLine(gc.Sample(s)); // 結果：123

            // コンパイルエラーとなる
            // var g = new GenericClassSub<int>();
        }
    }
}
