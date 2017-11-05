using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class ExceptionChecked
    {
        public static void Main()
        {
            // オーバーフローを検出
            checked
            {
                try
                {
                    byte b = byte.MaxValue;
                    // 最大値からさらに+1
                    b++;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("byte型のオーバーフローを検出");
                }
            }
        }
    }
}
