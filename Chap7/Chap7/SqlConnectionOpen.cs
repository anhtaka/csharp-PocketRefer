using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Chap7
{
    class SqlConnectionOpen
    {
        static void Main(string[] args)
        {
            //接続文字列
            string connectionString = @"Data Source=.\SQLEXPRESS;
					Initial Catalog=pr_cs_sampleDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //接続を開く
                conn.Open();
                Console.WriteLine("データベースに接続しました。State={0}",
                                    conn.State);
                //データベースへのクエリなどを実行する。
                //usingブロックを抜けるときにClose()が呼ばれる。
            }
            Console.WriteLine("データベースに接続しました。");
        }
    }
}
