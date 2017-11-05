using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    // デリゲートの宣言
    delegate int SampleDelegate3(int x);

    class DelegateLambda
    {
        static void Main()
        {
            // ラムダ式によるデリゲート
            SampleDelegate3 d = n => -n;
            Console.WriteLine(d(3)); // 結果:-3

            // Action<int>は、戻り値のない引数ひとつの定義済み汎用デリゲート
            Action<int> disp = n => { Console.WriteLine(n); }; // 結果:123
            disp(123); 

            // Func<string, int>は、戻り値と引数ひとつの定義済み汎用デリゲート
            Func<string, int> hex2int = str => Convert.ToInt32(str, 16);
            Console.WriteLine(hex2int("CD"));        // 出力値:205
        }
    }
}
