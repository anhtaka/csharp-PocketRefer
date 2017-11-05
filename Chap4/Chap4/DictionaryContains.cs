using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class DictionaryContains
    {
        public static void Main(string[] args)
        {
            //空のディクショナリを作成
            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            //ディクショナリに値を追加
            dict1.Add("りんご", 150);
            dict1.Add("みかん", 100);
            dict1.Add("キウィ", 200);

            Console.WriteLine("キー「りんご」は含まれるか:" 
                + dict1.ContainsKey("りんご"));
            Console.WriteLine("バリュー「300」のものはあるか:" 
                + dict1.ContainsValue(300));

            Console.ReadKey();
        }
    }
}
