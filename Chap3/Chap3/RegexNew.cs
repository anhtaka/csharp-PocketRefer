using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Chap3
{
    class RegexNew
    {
        public static void Main(string[] args)
        {
            //小文字アルファベット1文字に相当する正規表現
            Regex regex1 = new Regex("[a-z]");

            //アルファベット、数字でなる文字列に相当する正規表現
            Regex regex2 = new Regex("[a-zA-Z0-9]*");

            //郵便番号（7桁）に相当する正規表現
            Regex regex3 = new Regex("\\d{3}-\\d{4}");

            //b, ab, aab, aaab ,,,に対応する正規表現
            Regex regex4 = new Regex("a*b");

            //先頭に○、末尾に。に相当する正規表現
            Regex regex5 = new Regex("^○.*。$");

            //すべてカタカナに相当する正規表現
            Regex regex6 = new Regex(@"^\p{IsKatakana}*$");

            //すべて半角カタカナに相当する正規表現
            //文字コードで半角カタカナの範囲を指定
            Regex regex7 = new Regex("^[\\uFF61-\\uFF9F]*$");
            

        }
    }
}
