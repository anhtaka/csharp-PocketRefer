using System;
using System.Collections.Generic;
using System.Linq;

namespace Chap7
{
    class QueryableGroupBy
    {
        static void Main(string[] args)
        {
            using (var context = new SolarSystemContext())
            {
                //クエリ式
                var query = from m in context.Moons
                            group m by m.Planet;
                //メソッド式
                //var query = context.Moons.GroupBy(m=>m.Planet);

                foreach (var g in query)
                {
                    //グループ化のキーをKeyプロパティで参照する
                    Console.WriteLine("{0}の衛星グループ:", g.Key.Name);
                    //グループをコレクションとして要素をforeachで表示
                    foreach (var moon in g)
                    {
                        Console.Write("{0},", moon.Name);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}