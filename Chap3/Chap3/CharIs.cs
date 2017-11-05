using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Chap3
{
    public class CharIs
    {
        public static void Main(string[] args)
        {
            char digit = '１';    //全角数字
            Console.WriteLine("{0} IsDigit : {1}", digit, char.IsDigit(digit));

            char number1 = 'Ⅱ';  //ローマ数字
            char number2 = '③';  //丸付き数字
            //ローマ数字、丸付き数字はIsDigitではfalseだが、IsNumberならばtrue
            Console.WriteLine(
                "{0} IsDigit : {1}, IsNumber : {2}"
                , number1, char.IsDigit(number1), char.IsNumber(number1));
            Console.WriteLine(
                "{0} IsDigit : {1}, IsNumber : {2}"
                , number2, char.IsDigit(number2), char.IsNumber(number2));

            char cr = '\n';      //改行コード
            Console.WriteLine("\\n IsControl : {0}"
                , char.IsControl(cr));

            char lowerChar = 'l';//小文字 
            Console.WriteLine("{0} IsLower : {1}"
                , lowerChar, char.IsLower(lowerChar));

            char upperChar = 'U';//大文字
            Console.WriteLine("{0} IsUpper : {1}"
                , upperChar, char.IsUpper(upperChar));

            char zenspace = '　';    //全角スペース
            Console.WriteLine("{0} IsWhiteSpace : {1}"
                , zenspace, char.IsWhiteSpace(zenspace));

            Console.ReadKey();
        }

    }
}
