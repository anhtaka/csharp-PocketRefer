using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class Sample
    {
    }
    class ClassIs : Sample
    {
        public static void Main()
        {
            var c1 = new ClassIs();
            Console.WriteLine(c1 is Sample); // 結果：True
            Console.WriteLine(c1 is string); // 結果：False
        }
    }

}
