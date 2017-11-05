using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class DictionaryItem
    {
        public static void Main(string[] args)
        {
            //空のディクショナリを作成
            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            //ディクショナリに値を追加
            dict1.Add("りんご", 150);
            dict1.Add("みかん", 100);
            dict1.Add("キウィ", 200);

            //インデクサでバリューを取得
            Console.WriteLine("りんごの値段:" + dict1["りんご"]);

            int value;
            bool result = dict1.TryGetValue("みかん", out value);
            if(result)
                Console.WriteLine("みかんの値段:" + value);

            try
            {
                Console.WriteLine(dict1["ぶどう"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("KeyNotFoundException発生");
            }

            Console.ReadKey();
        }
    }
}
