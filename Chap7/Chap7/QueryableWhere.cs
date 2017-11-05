using System;
using System.Collections.Generic;
using System.Linq;

namespace Chap7
{
    class QueryableWhere
    {
        static void Main(string[] args)
        {
            using (var context = new SolarSystemContext())
            {
                //メソッド式
                var moons = context.Moons.Where(m => m.Radius > 1000);
                ////クエリ式
                //var moons = from m in context.Moons
                //            where m.Radius > 1000
                //            select m;

                Console.WriteLine("平均半径が1000km超えている衛星：");
                foreach (var moon in moons)
                {
                    Console.Write("{0}(平均半径={1}km),",
                        moon.Name, moon.Radius);
                }
            }
        }
    }
}