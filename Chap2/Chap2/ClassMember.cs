using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class Square
    {
        // フィールド
        public float width;
        public float height;

        // 面積を求めるメソッド
        public float GetArea()
        {
            return this.width * this.height;
        }
    }

    class ClassMember
    {
        static void Main(string[] args)
        {
            Square sqar = new Square();

            sqar.width = 10;
            sqar.height = 5;

            Console.WriteLine("面積：" + sqar.GetArea());
        }
    }
}
