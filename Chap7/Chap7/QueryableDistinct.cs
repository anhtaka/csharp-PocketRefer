using System;
using System.Collections.Generic;
using System.Linq;

namespace Chap7
{
    class QueryableDistinct
    {
        static void Main(string[] args)
        {
            using (var context = new SolarSystemContext())
            {
                var query = from m in context.Moons
                            select m.DiscoveryYear;
                Console.WriteLine("登録されている衛星の発見年：");
                foreach (var y in query)
                {
                    Console.Write("{0},", y);
                }
                Console.WriteLine();
                Console.WriteLine("重複を取り除くと");
                var distinctQuery = query.Distinct();
                foreach (var y in distinctQuery)
                {
                    Console.Write("{0},", y);
                }
                Console.WriteLine();
            }
        }
    }
}