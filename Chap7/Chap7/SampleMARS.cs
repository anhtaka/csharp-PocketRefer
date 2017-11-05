using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace Chap7
{
    class SampleMARS
    {
        //接続文字列
        public static string connectionString =
            @"Data Source=.\SQLEXPRESS;
         Initial Catalog=pr_cs_sampleDB;
         Integrated Security=True"+
         ";MultipleActiveResultSets=true";
        static void Main(string[] args)
        {
            //SQLクエリ文
            string sql = "SELECT * FROM authors;";
            string sql2 = "SELECT * FROM bookauthor WHERE AUTHOR_ID=@id;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //クエリに対応するオブジェクトを生成する。
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(
                        "{0}の著作BOOK_IDは：", sdr["NAME"]);
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);
                    cmd2.Parameters
                        .AddWithValue("@id", sdr["AUTHOR_ID"]);
                    SqlDataReader sdr2 = cmd2.ExecuteReader();
                    while (sdr2.Read())
                    {
                        Console.Write("\t{0},", sdr2["BOOK_ID"]);
                    }
                    Console.WriteLine();
                    sdr2.Close();
                }
                sdr.Close();
            }
        }
    }
}
