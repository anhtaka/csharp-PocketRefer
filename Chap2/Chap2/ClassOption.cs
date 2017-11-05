using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class ClassOption
    {
        public void Method(int a, string b = "default", int c = 10)
        {
            Console.WriteLine("{0},{1},{2}", a, b, c);
        }
 
        static void Main()
        {
            new ClassOption().Method(5); // 結果：5,default,10
            new ClassOption().Method(b:"sample",a:1); // 結果：1,sample,10
        }
    }
}
