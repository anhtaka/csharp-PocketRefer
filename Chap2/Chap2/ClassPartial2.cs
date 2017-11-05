using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    partial class ClassPartial2
    {
        static partial void logInfo();
        static void Main()
        {
            // debugが表示され、その後に、Helloが表示される
            logInfo();
            Console.WriteLine("Hello");
        }
    }
}
