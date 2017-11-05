using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Chap2
{
    class ExceptionUsing
    {
        public static void Main()
        {
            try
            {
                // ファイルのオープン
                using (StreamReader sr = new StreamReader("Exception4.cs", System.Text.Encoding.Default))
                {
                    // ファイル処理
                    string text = sr.ReadToEnd();
                    Console.Write(text);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
