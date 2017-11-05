using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class OperatorSubs
    {
        static void Main(string[] args)
        {
            int x = 15;
            long y = x;
            // byte  z = x; では「暗黙的に変換できません」と表示される
            byte z = (byte)x;

            Console.WriteLine(z); 
        }

    }
}
