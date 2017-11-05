using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class Square2
    {
        // フィールド
        public float width;
        public float height;

        // コンストラクタ
        public Square2(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        // 面積を求めるメソッド
        public float GetArea()
        {
            return this.width * this.height;
        }
    }
    class ClassConstructor
    {
        static void Main(string[] args)
        {
            // Square2 sqar = new Square2(); エラー
            Square2 sqar = new Square2(10, 5);
            Console.WriteLine("面積：" + sqar.GetArea());
        }
    }
}
