using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class BasicSwitch
    {
        static void Main(string[] args)
        {
            int value = 1;

            switch (value)
            {
                // valueが1の場合
                case 1:
                    Console.WriteLine("first");
                    break;

                // valueが2の場合
                case 2:
                    Console.WriteLine("second");
                    break;
            }

            switch (value)
            {
                case 1:
                // break文の省略はできないが、処理の共有は可能
                // Console.WriteLine( "first" ); 
                case 2:
                case 3:
                    Console.WriteLine("second");
                    break;
            }
        }
    }
}
