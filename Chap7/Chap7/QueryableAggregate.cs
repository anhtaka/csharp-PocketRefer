using System;
using System.Collections.Generic;
using System.Linq;

namespace Chap7
{
    class QueryableAggregate
    {
        static void Main(string[] args)
        {
            using (var context = new SolarSystemContext())
            {
                //Averageメソッドの使用
                var average = context.Planets.Average(p => p.SemiMajorAxis);
                Console.WriteLine(
                 "登録されている惑星の平均軌道半径は{0}AUです。", average);

                //Countメソッドの使用
                var query = from p in context.Planets
                            select new { Name = p.Name,
                                         NumOfMoons = p.Moons.Count() };
                foreach (var planetInfo in query)
                {
                    Console.WriteLine(
                        "{0}系には{1}個の衛星が登録されています。",
                        planetInfo.Name, planetInfo.NumOfMoons);
                }
                //Sumメソッドの使用
                Console.WriteLine("合計:{0}の衛星が登録されています。",
                    query.Sum(x => x.NumOfMoons));
                //Maxメソッドの使用
                var max = context.Moons.Max(p => p.Radius);
                Console.WriteLine(
                    "登録されている衛星の中で最大の半径は{0}kmです", max);
            }
        }
    }
}