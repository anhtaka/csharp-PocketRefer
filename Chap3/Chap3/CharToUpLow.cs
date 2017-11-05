using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Chap3
{
    public class CharToUpLow
    {
        public static void Main(string[] args)
        {
            //小文字化
            Console.WriteLine(char.ToLower('A'));

            //トルコ語のiの大文字化
            CultureInfo tr = new CultureInfo("tr-TR");
            char trI = char.ToUpper('i', tr);
            //日本語環境では文字化け
            Console.WriteLine(trI);

            //インバリアント カルチャで大文字化
            char invariantI = char.ToUpperInvariant('i');
            Console.WriteLine(invariantI);

            //インバリアント カルチャでの大文字化は結果が異なる
            Console.WriteLine(invariantI.Equals(trI));
            Console.ReadKey();
        }


    }
}
