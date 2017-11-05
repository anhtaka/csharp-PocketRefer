using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class BasicEnum
    {
        enum Signal { BLUE,YELLOW,RED }
        void sample(Signal s)
        {
            if ((int)s == 0)
                Console.WriteLine("進め");
            switch (s)
            {
                case Signal.RED:
                case Signal.YELLOW:
                    Console.WriteLine("停止");
                    break;
            }
        }

        static void Main(string[] args)
        {
            new BasicEnum().sample(Signal.RED);  // 結果：停止
            new BasicEnum().sample(Signal.BLUE); // 結果：進め
        }
    }
}
