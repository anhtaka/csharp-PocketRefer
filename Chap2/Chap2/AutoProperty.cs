using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2
{
    class AutoProperty
    {
        // 初期化可能
        public string Name { get; set; } = "sample";
        // getterのみ
        public int No { get; } = 1;
        // コンストラクタでの設定も可能
        // public AutoProperty() { this.No = 2; }
        static void Main(string[] args)
        {
            var m = new AutoProperty();
            Console.WriteLine(m.No);
        }
    }

}
