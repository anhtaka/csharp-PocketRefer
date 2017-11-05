using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    struct Simple
    {
        public int number;
        public string name;
    }

    class ClassStruct
    {
        static void Main()
        {
            Simple ss;  // 値型なのでnewは不要

            ss.number = 0;
            ss.name = "test";

            Console.WriteLine(ss.number);   // 結果: 0
            Console.WriteLine(ss.name);     // 結果: test
        }
    }

}
