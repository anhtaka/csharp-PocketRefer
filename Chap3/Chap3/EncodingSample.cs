using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class EncodingSample
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("クラス名, エンコーディング名, コードページ値");
            //シフトJIS取得
            Encoding sjis = Encoding.GetEncoding("shift-jis");
            //クラス名, エンコーディング名, コードページ値を出力（以下同様）
            Console.WriteLine("{0},{1},{2}"
                ,sjis.ToString(), sjis.EncodingName, sjis.CodePage);
            //JIS
            Encoding jis = Encoding.GetEncoding("iso-2022-jp");
            Console.WriteLine("{0},{1},{2}"
                , jis.ToString(), jis.EncodingName, jis.CodePage);
            //EUC
            Encoding euc = Encoding.GetEncoding("euc-jp");
            Console.WriteLine("{0},{1},{2}"
                , euc.ToString(), euc.EncodingName, euc.CodePage);
            //UTF-8
            Encoding utf8 = Encoding.UTF8;
            Console.WriteLine("{0},{1},{2}"
                , utf8.ToString(), utf8.EncodingName, utf8.CodePage);
            //Unicode(UTF-8)
            Encoding utf16 = Encoding.GetEncoding(1200);
            Console.WriteLine("{0},{1},{2}"
                , utf16.ToString(), utf16.EncodingName, utf16.CodePage);

            string s = "abcあいう１２３";
            //各文字コードでバイト列に変換
            //BitConverter.ToStringメソッドはバイト配列を文字列に変換する
            Console.WriteLine("sjis:" + BitConverter.ToString(sjis.GetBytes(s)));
            Console.WriteLine("jis:" + BitConverter.ToString(jis.GetBytes(s)));
            Console.WriteLine("euc:" + BitConverter.ToString(euc.GetBytes(s)));
            Console.WriteLine("utf8:" + BitConverter.ToString(utf8.GetBytes(s)));
            Console.WriteLine("Unicode:" + BitConverter.ToString(utf16.GetBytes(s)));

            Console.ReadKey();
        }
    }
}
