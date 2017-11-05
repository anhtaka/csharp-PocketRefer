using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class DictionaryNew
    {
        public static void Main(string[] args)
        {
            //空のディクショナリを作成
            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            //ディクショナリに値を追加
            dict1.Add("りんご", 150);
            dict1.Add("みかん", 100);
            dict1.Add("キウィ", 200);

            //ディクショナリをコピーして新しいディクショナリを作成
            Dictionary<string, int> dict2 = new Dictionary<string, int>(dict1);
            dict2.Add("すいか", 800);

            Console.WriteLine("みかんが含まれるか:" + dict2.ContainsKey("みかん"));

            Console.ReadKey();
        }
    }

}
