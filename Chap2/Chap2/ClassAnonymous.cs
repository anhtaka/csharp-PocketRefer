using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class ClassAnonymous
    {
        static void Main()
        {
            var top1 = new { Name = "MAEDA", Age = 20 };
            Console.WriteLine(top1.Age);        // 出力値：20

            string ID = "0002";
            var member = new { Name = "OHSHIMA", ID, ID.Length };  // 識別子は推論される
            Console.WriteLine(member.ID);       // 出力値：0002
            Console.WriteLine(member.Length);   // 出力値：4
        }
    }
}
