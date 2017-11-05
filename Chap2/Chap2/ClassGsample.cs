using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    // 型パラメータを使ったクラス定義
    class GenericClass<T>
    {
        T value;

        public void SetValue(T val)
        {
            value = val;
        }

        public T GetValue()
        {
            return value;
        }
    }

    class ClassGsample
    {
        static void Main()
        {
            // IntegerクラスのGenericClass
            GenericClass<int> gc1 = new GenericClass<int>();
            gc1.SetValue(123);
            Console.WriteLine(gc1.GetValue()); // 結果：123

            // StringクラスのGenericClass
            GenericClass<String> gc2 = new GenericClass<String>();
            gc2.SetValue("文字列");
            Console.WriteLine(gc2.GetValue()); // 結果：文字列

            // 型が異なるのでコンパイルできない
            // gc2.SetValue(123);
        }
    }
}
