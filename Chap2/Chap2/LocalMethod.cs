using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2
{
    class LocalMethod
    {
        static void Main(string[] args)
        {
            // ローカル関数（Mainメソッドのみで利用可能）
            int multi(int x, int y)
            {
                return x * y;
            }
            // ラムダ式を使って以下のようにも書ける
            // int multi(int x, int y) => x * y;

            Console.WriteLine(multi(3, 5)); // 結果:15
        }
    }
}
