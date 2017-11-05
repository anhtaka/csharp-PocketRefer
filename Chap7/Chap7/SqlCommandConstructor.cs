using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace Chap7
{
    class SqlCommandConstructor
    {
        //接続文字列
        public static string connectionString =
            ConfigurationManager.ConnectionStrings["SQLEXP"].ConnectionString;
        static void Main(string[] args)
        {
            //SQLクエリ文
            string sql = "SELECT TITLE,TYPE,PRICE FROM books;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //クエリに対応するオブジェクトを生成する。
                SqlCommand cmd = new SqlCommand(sql, conn);
                Console.WriteLine("接続文字列「{0}」の接続先に対して",
                    cmd.Connection.ConnectionString);
                Console.WriteLine("sql「{0}」を発行します", cmd.CommandText);
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
            }
        }
    }
}
