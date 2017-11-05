using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class MathRound
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Floor(1.2), Ceiling(1.2), Round(1.2):{0},{1},{2}",
                Math.Floor(1.2),Math.Ceiling(1.2),Math.Round(1.2));
            Console.WriteLine("Floor(2.5), Ceiling(2.5), Round(2.5):{0},{1},{2}",
                Math.Floor(2.5), Math.Ceiling(2.5), Math.Round(2.5));
            //AwayFromZeroなので四捨五入で3
            Console.WriteLine("Round(2.5,MidpointRounding.AwayFromZero):"
                + Math.Round(2.5, MidpointRounding.AwayFromZero));

            Console.WriteLine("Floor(-1.2), Ceiling(-1.2), Round(-1.2):{0},{1},{2}",
                Math.Floor(-1.2), Math.Ceiling(-1.2), Math.Round(-1.2));

            //ToEvenなので2.145は対象の2桁目が偶数の2.14に丸められる
            Console.WriteLine("Round(2.145,2):" + Math.Round(2.145, 2));
            //AwayFromZeroなので対象桁までの四捨五入で2.15に丸められる
            Console.WriteLine("Round(2.145,2,MidpointRounding.AwayFromZero):"
                + Math.Round(2.145,2, MidpointRounding.AwayFromZero));
            
            Console.ReadKey();
        }
    }
}
