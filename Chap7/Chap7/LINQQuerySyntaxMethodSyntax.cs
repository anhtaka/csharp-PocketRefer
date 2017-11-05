using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQQuerySyntaxMethodSyntax
{
    public class Moon
    {
        public string Name { get; set; }
        public virtual Planet Planet { get; set; }
        public int Radius { get; set; }
    }
    public class Planet
    {
        public string Name { get; set; }
        public float SemiMajorAxis { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Planet earth = new Planet { Name = "地球", SemiMajorAxis = 1f };
            Planet mars = new Planet { Name = "火星", SemiMajorAxis = 1.52366f };
            IList<Moon> Moons = new List<Moon>();
            Moons.Add(new Moon { Name = "月", Planet = earth, Radius = 1738 });
            Moons.Add(new Moon { Name = "ダイモス", Planet = mars, Radius = 6 });
            Moons.Add(new Moon { Name = "フォボス", Planet = mars, Radius = 11 });

            //クエリ式 from (要素) in (シーケンス)... select (要素からの射影) 
            var query = from m in Moons
                        where m.Radius > 10
                        select new { Name = m.Name, Parent = m.Planet.Name };

            //メソッド式とラムダ式
            //var query = Moons
            //    .Where(m=> m.Radius >10)
            //    .Select(m => new { Name = m.Name, Parent = m.Planet.Name });

            //クエリはforeachで実行される
            foreach (var mp in query)
            {
                Console.WriteLine("{0}は{1}の衛星です。", mp.Name, mp.Parent);
            }

        }
    }
}
