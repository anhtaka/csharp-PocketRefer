using System;
using System.Collections.Generic;
using System.Linq;

namespace Chap7
{
    class QueryableContains
    {
        static void Main(string[] args)
        {
            using (var context = new SolarSystemContext())
            {
                int radius = 1000;
                //半径1000km以上の衛星の名前を取得するクエリ
                var bigMoonNames = from m in context.Moons
                                   where m.Radius > radius
                                   select m.Name;
                string theMoonName = "月";
                //上記クエリの結果に「月」が含まれていればtrue
                if (bigMoonNames.Contains(theMoonName))
                {
                    Console.WriteLine(
                        "{0}は半径{1}km以上の衛星に含まれています。",
                        theMoonName, radius);
                }
            }
        }
    }
}