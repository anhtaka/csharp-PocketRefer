using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    // インターフェース
    interface IGetInfo
    {
        void getInfo();

        // プロパティ
        int px { get; set; }
    }
    // インターフェースの実装
    class ClassInf : IGetInfo
    {
        int x = 0;

        public void getInfo()
        {
            Console.WriteLine("Sample");
        }
        public int px
        {
            get { return x; }
            set { x = value; }
        }

        static void Main()
        {
            new ClassInf().getInfo(); // 結果：Sample

            var c = new ClassInf();
            c.px = 10;
            Console.WriteLine(c.px); // 結果：10
        }
    }
}
