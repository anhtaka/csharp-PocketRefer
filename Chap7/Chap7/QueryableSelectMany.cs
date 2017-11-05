using System;
using System.Collections.Generic;
using System.Linq;

namespace Chap7
{
    class QueryableSelectMany
    {
        static void Main(string[] args)
        {
            using (var context = new SolarSystemContext())
            {
                //クエリ式
                var moonNames = from p in context.Planets
                                from m in p.Moons
                                select new { Name = m.Name, Parent = p.Name };
                ////メソッド式
                //var moonNames = context.Planets
                //   .SelectMany(p => p.Moons
                //   .Select(m => new { Name = m.Name, Parent = p.Name }));

                foreach (var item in moonNames)
                {
                    Console.WriteLine("{0}は{1}を衛星としている。",
                        item.Parent, item.Name);
                }
            }
        }
    }
}