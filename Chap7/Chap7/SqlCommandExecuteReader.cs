using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace Chap7
{
    class SqlCommandExecuteReader
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
                Console.WriteLine("データベースに接続しました。");
                //SQLを実行して結果を取得する
                SqlDataReader sdr = cmd.ExecuteReader();
                Console.WriteLine("SQL「{0}」を発行しました。",
                    cmd.CommandText);
                Console.WriteLine(sdr.HasRows   ? "1行以上の結果があります。" 
                                                : "結果がありません。");
                //結果の読み取りと処理
                //・・・
                //SqlDataReaderを閉じる
                sdr.Close();
            }
        }
    }
}
