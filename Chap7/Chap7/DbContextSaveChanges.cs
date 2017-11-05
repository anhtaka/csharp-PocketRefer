using System;
using System.Collections.Generic;

namespace Chap7
{
    class DbContextSaveChanges
    {
        static void Main(string[] args)
        {
            using (var context = new SolarSystemContext())
            {
                //Planetオブジェクトの生成
                var mercury = new Planet { Name = "水星",
                                           SemiMajorAxis = 0.3871f };
                var venus = new Planet { Name = "金星",
                                           SemiMajorAxis = 0.72333f };
                var earth = new Planet { Name = "地球",
                                           SemiMajorAxis = 1f };
                var mars = new Planet { Name = "火星",
                                           SemiMajorAxis = 1.52366f };
                var jupiter = new Planet { Name = "木星",
                                           SemiMajorAxis = 5.20336f };
                var saturn = new Planet { Name = "土星",
                                           SemiMajorAxis = 9.53707f };
                var uranus = new Planet { Name = "天王星",
                                           SemiMajorAxis = 19.19138f };
                var neptune = new Planet { Name = "海王星",
                                           SemiMajorAxis = 30.06896f };
                var pluto = new Planet { Name = "冥王星",
                                           SemiMajorAxis = 39.445f };
                //Planetオブジェクトの追加
                context.Planets.Add(mercury);
                context.Planets.Add(venus);
                context.Planets.Add(earth);
                context.Planets.Add(mars);
                context.Planets.Add(jupiter);
                context.Planets.Add(saturn);
                context.Planets.Add(uranus);
                context.Planets.Add(neptune);
                context.Planets.Add(pluto);
                //Moonオブジェクトの生成と追加
                context.Moons.Add(new Moon
                {
                    Name = "月",
                    Planet = earth,
                    Radius = 1738,
                    SemiMajorAxis = 384400
                });
                context.Moons.Add(new Moon
                {
                    Name = "ダイモス",
                    Planet = mars,
                    Radius = 6,
                    SemiMajorAxis = 23400,
                    DiscoveryYear = 1877
                });
                context.Moons.Add(new Moon { Name = "フォボス", Planet = mars, Radius = 11, SemiMajorAxis = 9387, DiscoveryYear = 1877 });
                context.Moons.Add(new Moon { Name = "イオ", Planet = jupiter, Radius = 1821, SemiMajorAxis = 421700, DiscoveryYear = 1610 });
                context.Moons.Add(new Moon { Name = "エウロパ", Planet = jupiter, Radius = 1565, SemiMajorAxis = 671034, DiscoveryYear = 1610 });
                context.Moons.Add(new Moon { Name = "ガニメデ", Planet = jupiter, Radius = 2634, SemiMajorAxis = 1070412, DiscoveryYear = 1610 });
                context.Moons.Add(new Moon { Name = "カリスト", Planet = jupiter, Radius = 2403, SemiMajorAxis = 1882709, DiscoveryYear = 1610 });
                context.Moons.Add(new Moon { Name = "ミマス", Planet = saturn, Radius = 199, SemiMajorAxis = 185404, DiscoveryYear = 1789 });
                context.Moons.Add(new Moon { Name = "エンケラドゥス", Planet = saturn, Radius = 249, SemiMajorAxis = 237950, DiscoveryYear = 1789 });
                context.Moons.Add(new Moon { Name = "テティス", Planet = saturn, Radius = 530, SemiMajorAxis = 294619, DiscoveryYear = 1684 });
                context.Moons.Add(new Moon { Name = "ディオネ", Planet = saturn, Radius = 560, SemiMajorAxis = 377396, DiscoveryYear = 1684 });
                context.Moons.Add(new Moon { Name = "レア", Planet = saturn, Radius = 764, SemiMajorAxis = 527180, DiscoveryYear = 1672 });
                context.Moons.Add(new Moon { Name = "タイタン", Planet = saturn, Radius = 2575, SemiMajorAxis = 1221930, DiscoveryYear = 1655 });
                context.Moons.Add(new Moon { Name = "ヒペリオン", Planet = saturn, Radius = 143, SemiMajorAxis = 1481010, DiscoveryYear = 1848 });
                context.Moons.Add(new Moon { Name = "イアペトゥス", Planet = saturn, Radius = 718, SemiMajorAxis = 3560820, DiscoveryYear = 1671 });
                context.Moons.Add(new Moon { Name = "フェーベ", Planet = saturn, Radius = 110, SemiMajorAxis = 12869700, DiscoveryYear = 1899 });
                context.Moons.Add(new Moon { Name = "ミランダ", Planet = uranus, Radius = 236, SemiMajorAxis = 129390, DiscoveryYear = 1948 });
                context.Moons.Add(new Moon { Name = "アリエル", Planet = uranus, Radius = 579, SemiMajorAxis = 191020, DiscoveryYear = 1851 });
                context.Moons.Add(new Moon { Name = "ウンブリエル", Planet = uranus, Radius = 585, SemiMajorAxis = 266300, DiscoveryYear = 1851 });
                context.Moons.Add(new Moon { Name = "チタニア", Planet = uranus, Radius = 789, SemiMajorAxis = 435910, DiscoveryYear = 1787 });
                context.Moons.Add(new Moon { Name = "オベロン", Planet = uranus, Radius = 761, SemiMajorAxis = 583520, DiscoveryYear = 1787 });
                context.Moons.Add(new Moon { Name = "トリトン", Planet = neptune, Radius = 1352, SemiMajorAxis = 354800, DiscoveryYear = 1846 });
                context.Moons.Add(new Moon { Name = "ネレイド", Planet = neptune, Radius = 170, SemiMajorAxis = 5513400, DiscoveryYear = 1949 });
                context.Moons.Add(new Moon { Name = "カロン", Planet = pluto, Radius = 635, SemiMajorAxis = 19571, DiscoveryYear = 1978 });
                //データベースへの保存
                int num = context.SaveChanges();
                Console.WriteLine("データベースに保存しました。");
                Console.WriteLine("変更行数:\t{0}", num);
            }
        }
    }
}