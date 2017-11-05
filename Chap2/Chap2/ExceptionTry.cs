using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class ExceptionTry
    {
        public static void Main()
        {
            // 独自の例外処理
            try
            {
                int a = 0;
                int b = 5 / a;
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("終了処理");
            }
        }
    }
}
