using System;
using System.Collections.Generic;
using System.Linq;

namespace Chap7
{
    class QueryableAllAny
    {
        static void Main(string[] args)
        {
            using (var context = new SolarSystemContext())
            {
                string planet = "木星";
                Console.WriteLine("{0}の衛星：", planet);
                var query = from m in context.Moons
                            where m.Planet.Name == planet
                            select m;
                foreach (var m in query)
                {
                    Console.Write("{0}({1}km),", m.Name, m.Radius);
                }
                Console.WriteLine();
                int year = 1610;
                //Allメソッド：クエリ結果がすべてが引数の条件を満たすときtrue
                if (query.All(m => m.DiscoveryYear == year))
                {
                    Console.WriteLine(
                     "これらの衛星はすべて{0}年に発見されました。", year);
                }
                int radius = 2500;
                //Anyメソッド：クエリ結果の1つ以上が引数の条件を満たすときtrue
                if (query.Any(m => m.Radius > radius))
                {
                    Console.WriteLine(
                     "これらの衛星の中に平均半径が{0}kmを"
                     +"上回るものがあります。", radius);
                }
            }
        }
    }
}