using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2
{
    class Program
    {
        private int field = 3;
        static void Main(string[] args)
        {
            Console.WriteLine(nameof(Program));　// 結果：Program
            Console.WriteLine(nameof(field));    // 結果：filed
        }
    }
}
