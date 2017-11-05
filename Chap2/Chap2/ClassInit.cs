using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class Square3
    {
        // フィールド
        public float width;
        public float height;
    }
    class ClassInit
    {
        static void Main(string[] args)
        {
            Square3 sqar1 = new Square3 { width = 10, height = 5 };
            Square3 sqar2 = new Square3 { width = 50 };
        }
    }
}
