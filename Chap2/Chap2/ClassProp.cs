using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class ClassProp
    {
        // public int TypeProp { get; set; } とも書ける
        int val;
        public int TypeProp
        {
            private set { this.val = value; }  // 個別にアクセスレベルの指定も可
            get { return this.val;  }
        }
        static void Main()
        {
            var c = new ClassProp();
            c.TypeProp = 5;                 // setが呼ばれる
            Console.WriteLine(c.TypeProp);  // getが呼ばれる
        }
    }
}
