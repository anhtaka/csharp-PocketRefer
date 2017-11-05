using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2
{
    class IndexInitializer
    {
        static void Main(string[] args)
        {
            // インデックス初期化子
            var dic = new Dictionary<int, string>
            {
                [0] = "first",
                [1] = "second"
            };

            // 従来の書き方
            var old = new Dictionary<int, string>();
            old[0] = "first";
            old[1] = "second";
        }
    }
}
