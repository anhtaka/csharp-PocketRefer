using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace Chap7
{
    class SqlCommandExecuteScalar
    {
        //接続文字列
        public static string connectionString =
            ConfigurationManager.ConnectionStrings["SQLEXP"].ConnectionString;
        static void Main(string[] args)
        {
            //SQLクエリ文
            string sql = "SELECT COUNT(*) FROM books;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                //集計関数などのSQLで結果が1行1列になる場合には
                //ExecuteScalarを使用
                int x = (int)cmd.ExecuteScalar();
                Console.WriteLine("登録されている本のタイトル数は {0} です", x);
            }
        }
    }
}
