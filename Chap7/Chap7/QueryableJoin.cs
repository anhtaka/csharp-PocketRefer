using System;
using System.Collections.Generic;
using System.Linq;

namespace Chap7
{
    class QueryableJoin
    {
        static void Main(string[] args)
        {
            using (var context = new SolarSystemContext())
            {
                //クエリ式
                var query = from p in context.Planets
                            join m in context.Moons on p equals m.Planet
                            select new { Name = m.Name, ParentName = p.Name };
                ////メソッド式
                //var query = context.Planets
                //    .Join(context.Moons, p => p, m => m.Planet,
                //    (p, m) => new { Name = m.Name, ParentName = p.Name });

                foreach (var moon in query)
                {
                    Console.WriteLine("{0}は{1}の衛星",
                        moon.Name, moon.ParentName);
                }
            }
        }
    }
}