using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    class EncodingGetString
    {
        public static void Main(string[] args)
        {
            //シフトJISのバイト列
            byte[] sjisBytes = new byte[]{
                0x61,0x62,0x63,0x82,0xA0,0x82,0xA2
                ,0x82,0xA4,0x82,0x50,0x82,0x51,0x82,0x52
            };
            Encoding sjis = Encoding.GetEncoding("shift-jis");
            Console.WriteLine("sjis:" + sjis.GetString(sjisBytes));

            //UTF-8のバイト列
            byte[] utf8Bytes = new byte[]{
                0x61,0x62,0x63,0xE3,0x81,0x82,0xE3,0x81,0x84,0xE3,0x81
                ,0x86,0xEF,0xBC,0x91,0xEF,0xBC,0x92,0xEF,0xBC,0x93
            };
            Encoding utf8 = Encoding.UTF8;
            Console.WriteLine("utf8:" + utf8.GetString(utf8Bytes));

            //UTF-16のバイト列
            byte[] utf16Bytes = new byte[]{
                0x61,0x00,0x62,0x00,0x63,0x00,0x42,0x30,0x44
               ,0x30,0x46,0x30,0x11,0xFF,0x12,0xFF,0x13,0xFF
            };
            Encoding utf16 = Encoding.GetEncoding(1200);
            //バイト列の一部を変換
            Console.WriteLine("utf16:" + utf16.GetString(utf16Bytes, 4, 10));

            Console.ReadKey();
        }
    }
}
