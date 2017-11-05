using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Chap7
{
    class SqlDataReaderRead
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
                conn.Open();
                //結果を取得する
                SqlDataReader sdr = cmd.ExecuteReader();
                //フィールド名
                Console.WriteLine("TITLE\tTYPE\tPRICE");

                //結果を1行ずつ読み取る
                while (sdr.Read())
                {
                    //フィールド名により値を取得
                    Console.WriteLine("{0}\t{1}\t{2}",
                        sdr["TITLE"], sdr["TYPE"], sdr["PRICE"]);
                }
                //SqlDataReaderを閉じる
                sdr.Close();
            }
        }
    }
}
