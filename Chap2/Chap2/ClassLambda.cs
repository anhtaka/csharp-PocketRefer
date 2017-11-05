using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2
{
    public class Rect
    {
        public int H { get; set; }
        public int W { get; set; }
        // ラムダ式での定義
        public int Area() => H * W;

        // getのみのプロパティも可能
        public int No => 1;
        // public int No { get; } = 1; の省略形
    }

    class ClassLambda
    {
        static void Main(string[] args)
        {
            var r = new Rect()
            {
                H = 2,
                W = 4
            };
            Console.WriteLine(r.Area()); // 8
            Console.WriteLine(r.No);     // 1
        }

    }
}
