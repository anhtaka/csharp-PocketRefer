using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class DictionaryAdd
    {
        public static void Main(string[] args)
        {
            //空のディクショナリを作成
            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            //ディクショナリに値を追加
            dict1.Add("りんご", 150);
            dict1.Add("みかん", 100);
            dict1.Add("キウィ", 200);
            dict1.Add("すいか", 800);

            //ディクショナリの内容を表示
            foreach (string key in dict1.Keys)
            {
                Console.WriteLine("{0} : {1}", key, dict1[key]);
            }

            Console.ReadKey();
        }
    }
}
