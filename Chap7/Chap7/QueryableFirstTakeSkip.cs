using System;
using System.Collections.Generic;
using System.Linq;

namespace Chap7
{
    class QueryableFirstTakeSkip
    {
        static void Main(string[] args)
        {
            using (var context = new SolarSystemContext())
            {
                //半径の降順に並べてFirstメソッドで最初の要素を取得
                var query = context.Moons.OrderByDescending(m => m.Radius);
                Moon first = query.First();
                Console.WriteLine("登録されている衛星の中で"+
                    "最大の半径持つのは{0}({1}km)です。",
                    first.Name, first.Radius);
                //Takeメソッドの使用
                Console.WriteLine("登録されている衛星を半径が大きい順に5つ");
                var top5 = query.Take(5);
                foreach (var moon in top5)
                {
                    Console.Write("{0},", moon.Name);
                }
                Console.WriteLine();
                //Skipメソッドの使用
                Console.WriteLine("半径の大きさが大きい6位から10位を表示");
                var rem = query.Take(10).Skip(5);
                foreach (var moon in rem)
                {
                    Console.Write("{0},", moon.Name);
                }
                Console.WriteLine();
            }
        }
    }
}