using System;
using System.Collections.Generic;
using System.Linq;

namespace Chap7
{
    class ImmediateExecution
    {
        static void Main(string[] args)
        {
            using (var context = new SolarSystemContext())
            {
                var listOfPlanets = from p in context.Planets
                                    orderby p.SemiMajorAxis
                                    select p.Name.Substring(0, 1);
                //配列にする
                string[] ArrayOfPlanetNames
                    = listOfPlanets.ToArray<string>();
                //クエリを変更する（ArrayOfPlanetNamesは影響しない）
                listOfPlanets = from p in context.Planets
                                orderby p.SemiMajorAxis
                                select p.Name;
                //ジェネリックリストにする
                List<string> listOfPlanetNames
                    = listOfPlanets.ToList<string>();
                Console.Write("ArrayOfPlanetNames = ");

                //配列ArrayOfPlanetNamesの中身を表示
                Array.ForEach<string>(
                    ArrayOfPlanetNames,
                    name => Console.Write("{0},", name));
                Console.WriteLine();
                Console.Write("listOfPlanetNames = ");

                //ジェネリックリストlistOfPlanetNamesの中身を表示
                listOfPlanetNames.ForEach(
                    name => Console.Write("{0},", name));
                Console.WriteLine();
                var listOfMoons = context.Moons.Where(
                    m => m.Planet.Name == "木星");
                
                //辞書にする
                Dictionary<string, int> dictionary =
                    listOfMoons.ToDictionary<Moon, string, int>(
                        m => m.Name, m => m.Radius);
                string moon1 = "ガニメデ";
                Console.WriteLine("{0}の半径は{1}km",
                    moon1, dictionary[moon1]);

                //キーに対して複数の値が対応する辞書にする
                ILookup<int?, string> lookup =
                    context.Moons.ToLookup<Moon, int?, string>(
                        m => m.DiscoveryYear,
                        m => m.Name
                    );
                foreach (var group in lookup)
                {
                    if (group.Key != null)
                    {
                        Console.Write("{0}年発見の衛星:", group.Key);
                        foreach (var m in group)
                        {
                            Console.Write("{0},", m);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}