using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class ClassIndexer
    {
        string[] array = new string[10];

        // インデクサの定義
        public string this[int index]
        {
            set
            {
                if (index < array.Length) { array[index] = value; }
            }
            get
            {
                return (index < array.Length) ? array[index]:"なし";
            }
        }
        static void Main(string[] args)
        {
            var tmp = new ClassIndexer();

            // 配列のように代入できる
            tmp[0] = "あ";
            tmp[1] = "い";
            tmp[20] = "う";

            // 配列のように参照できる
            Console.WriteLine(tmp[1]);  // 結果：い
            Console.WriteLine(tmp[20]); // 結果：なし
        }
    }
}
