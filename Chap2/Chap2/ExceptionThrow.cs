using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class ExceptionThrow
    {
        public void ThrowSample()
        {
            Console.WriteLine("throwSample");
            // 例外のスロー
            throw new Exception("demo");
        }
        public static void Main()
        {
            try
            {
                new ExceptionThrow().ThrowSample();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
