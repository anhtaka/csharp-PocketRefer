using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Chap7
{
    class SqlCommandExecuteNonQuery
    {
        //接続文字列
        public static string connectionString =
            ConfigurationManager.ConnectionStrings["SQLEXP"].ConnectionString;
        static void Main(string[] args)
        {
            //SQLクエリ文
            string sql =
            @"INSERT INTO books 
                (BOOK_ID,TITLE,TYPE,PRICE,PUBDATE)
			    VALUES 
                ('100001','5次元の図形','科学',NULL,'2011-11-11');";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //クエリに対応するオブジェクトを生成する。
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                try
                {
                    //実行する
                    int num = cmd.ExecuteNonQuery();
                    Console.WriteLine("{0}行追加しました。", num);
                }
                catch (SqlException sqlex)
                {
                    foreach (SqlError error in sqlex.Errors)
                    {
                        Console.WriteLine("エラー番号:{0}, {1}", error.Number, error.Message);
                    }
                }
            }
        }
    }
}
