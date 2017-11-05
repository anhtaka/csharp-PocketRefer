using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Chap3
{
    public class StringLength
    {
        public static void Main(string[] args)
        {
            string s1 = "abcde";
            Console.WriteLine(s1.Length);
            //サロゲートペアを含む文字列。本来6文字
            string s2 = "𩸽(ほっけ)";
            //サロゲートペアを認識できず、7文字になってしまう
            Console.WriteLine("Length:" + s2.Length);

            //StringInfoクラスのLengthInTextElementsプロパティ
            StringInfo strInfo = new StringInfo(s2);
            //正しく6文字になる
            Console.WriteLine("StringInfo.LengthInTextElements:" + strInfo.LengthInTextElements);

            Console.ReadKey();
        }
    }

}
