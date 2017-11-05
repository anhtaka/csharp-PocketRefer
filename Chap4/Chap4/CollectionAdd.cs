using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class CollectionAdd
    {
        public static void Main(string[] args)
        {
            //int型のリストを生成
            List<int> intList1 = new List<int>();
            //int要素を追加
            intList1.Add(1);
            intList1.Add(2);
            intList1.Add(3);
            //追加した要素を表示
            foreach (int i in intList1)
            {
                Console.WriteLine(i);
            }

            //空のディクショナリを作成
            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            //ディクショナリに値を追加
            dict1.Add("りんご", 150);
            dict1.Add("みかん", 100);
            dict1.Add("キウィ", 200);
            //ディクショナリの内容を表示
            foreach (string key in dict1.Keys)
            {
                Console.WriteLine("{0} : {1}",key,dict1[key]);
            }

            Console.ReadKey();
        }
    }
}
