using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Chap7
{
    class ConfigurationManagerConnectionStrings
    {
        static void Main(string[] args)
        {
            //参照設定にSystem.Configurationを追加する必要がある
            //また、classの定義の外に、以下のようにusingディレクティブを記述すると、
            //System.Configuration名前空間のクラスは短いクラス名で参照できる
            //using System.Configuration;

            //接続文字列
            string connectionString =
                ConfigurationManager.ConnectionStrings["SQLEXP"].
                ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                Console.WriteLine("データベースに接続しました。");
                Console.WriteLine("接続文字列：{0}", conn.ConnectionString);
            }
        }
    }
}
