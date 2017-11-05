using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;
using static System.DateTime; // 構造体も可能

namespace Chap2
{
    class UsingStatic
    {
        static void Main(string[] args)
        {
            WriteLine(Sqrt(3 * 3 + 4 * 4)); // 5
            WriteLine(Now);                 // 2016/12/25 12:07:55
        }
    }
}
