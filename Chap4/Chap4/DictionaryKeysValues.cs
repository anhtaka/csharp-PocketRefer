using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4
{
    class DictionaryKeysValues
    {
        public static void Main(string[] args)
        {
            //空のディクショナリを作成
            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            //ディクショナリに追加
            dict1.Add("りんご", 150);
            dict1.Add("みかん", 100);
            dict1.Add("キウィ", 200);

            //キー、バリューのコレクションを取得
            Dictionary<string, int>.KeyCollection keys = dict1.Keys;
            Dictionary<string, int>.ValueCollection values = dict1.Values;

            //取得後に追加
            dict1.Add("オレンジ", 400);

            //キーのコレクションをforeachで反復処理
            foreach (string key in keys)
            {
                //キーのコレクション取得後の変更内容も表示
                Console.WriteLine("{0} : {1}", key, dict1[key]);
            }

            Console.ReadKey();
        }

    }
}
