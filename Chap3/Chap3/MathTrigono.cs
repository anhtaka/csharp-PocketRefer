using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class MathTrigono
    {
        public static void Main(string[] args)
        {
            int angle = 30;
            double radian = Math.PI / 180 * angle;

            Console.WriteLine("Sin30°:" + Math.Sin(radian));
            Console.WriteLine("Cos30°:" + Math.Cos(radian));
            Console.WriteLine("Tan30°:" + Math.Tan(radian));

            double cos = 0.5;
            Console.WriteLine("Cosが0.5になる角度:"
                + Math.Acos(cos) * 180 / Math.PI);

            double x = 1;
            double y = 1;
            Console.WriteLine("(x,y) = (1,1)になる角度:" 
                + Math.Atan2(y, x) * 180 / Math.PI);
            Console.ReadKey();
        }

    }
}
