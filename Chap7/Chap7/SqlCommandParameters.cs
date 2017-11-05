using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Chap7
{
    class SqlCommandParameters
    {
        //接続文字列
        public static string connectionString =
            ConfigurationManager.ConnectionStrings["SQLEXP"].ConnectionString;
        static void Main(string[] args)
        {
            //SQLクエリ文
            string sql = @"SELECT TITLE,TYPE,PRICE FROM books 
                            where PRICE<=@mymoney;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //クエリに対応するオブジェクトを生成する
                SqlCommand cmd = new SqlCommand(sql, conn);
                long mymoney =4400;
                Console.WriteLine("所持金={0}", mymoney);
                cmd.Parameters.AddWithValue("@mymoney", mymoney);
                conn.Open();
                //結果を取得する
                SqlDataReader sdr = cmd.ExecuteReader();
                if (!sdr.HasRows)
                {
                    Console.WriteLine("購入可能な本はありません。");
                }
                else
                {
                    Console.WriteLine("以下の書籍が購入可能です。");
                    Console.WriteLine("{0,-8}\t{1,-8}\t{2,-8}",
                        "TITLE", "TYPE", "PRICE");
                }
                //結果を1行ずつ読み取る
                while (sdr.Read())
                {
                    //フィールド名により値を取得
                    Console.WriteLine("{0,-8}\t{1,-8}\t{2,-8:￥0}",
                        sdr["TITLE"], sdr["TYPE"], sdr["PRICE"]);
                }
                //SqlDataReaderを閉じる
                sdr.Close();
            }
        }
    }
}
