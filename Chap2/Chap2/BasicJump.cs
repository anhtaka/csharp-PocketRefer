using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class BasicJump
    {
        static void Main(string[] args)
        {
             for (int i = 0; ; i++)
            {

                if (i < 8)
                {
                    continue;          // （i++の後に）ループの先頭に戻る
                }
                else if (i == 10)
                {
                    break;             // ループ中断
                }
                Console.WriteLine(i);
            }
        }
    }
}
