using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Chap7
{
    class SqlDataAdapterConstructor
    {
        //接続文字列
        public static string connectionString =
            ConfigurationManager.ConnectionStrings["SQLEXP"].ConnectionString;
        static void Main(string[] args)
        {
            //データ取得のためのSQL文
            string sql = "select * from books;";
            //SqlConnectionオブジェクトの生成
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //SQL文と接続を引数としてSqlDataAdapterオブジェクトを作成
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                //第1引数はSelectCommand.CommandTextに設定される
                Console.WriteLine("SelectCommand.CommandText:\t{0}",
                    da.SelectCommand.CommandText);
                //第2引数はSelectCommand.Connectionに設定される
                Console.WriteLine("SelectCommand.Connection:\t{0}",
                    da.SelectCommand.Connection.ConnectionString);
            }
        }
    }
}
