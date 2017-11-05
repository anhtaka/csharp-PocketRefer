using System;
using System.Collections.Generic;
using System.Linq;

namespace Chap7
{
    class QueryableOrderBy
    {
        static void Main(string[] args)
        {
            using (var context = new SolarSystemContext())
            {
                Console.WriteLine("名前の長さが短い順で、"
                    +"同じなら軌道半径の大きい順に表示します");
                //クエリ式ではorderbyを使用
                //並べ替えに使う列が複数の場合カンマ区切り
                //降順にする場合 descendingを付加
                var moons = from m in context.Moons
                            orderby m.Name.Length,
                                    m.SemiMajorAxis descending
                            select m;
                //メソッド式
                //並べ替えに使う列が複数の場合、
                //2つ目以降の列はThenByかThenByDescendingを使用
                //var moons = context.Moons
                //            .OrderBy(m => m.Name.Length)
                //            .ThenByDescending(m => m.SemiMajorAxis);

                foreach (var moon in moons)
                {
                    Console.WriteLine(
                        "{0}(名前文字列長={1},平均軌道半径={2}km)",
                        moon.Name, moon.Name.Length, moon.SemiMajorAxis);
                }
                Console.WriteLine();
            }
        }
    }
}