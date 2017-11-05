using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Chap7
{
    class SqlCommandExecuteReaderAsync
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
                Task<SqlDataReader> task = cmd.ExecuteReaderAsync();
                Console.WriteLine("SQL「{0}」を発行しました。",
                    cmd.CommandText);
                if (task.Status != TaskStatus.RanToCompletion)
                {
                    Console.WriteLine("タスク未完了時のタスク状態:{0}",
                        task.Status);
                }
                SqlDataReader sdr = task.Result;
                Console.WriteLine("結果取得後のタスク状態:{0}", task.Status);
                Console.WriteLine(sdr.HasRows   ? "1行以上の結果があります。" 
                                                : "結果がありません。");
                //結果の読み取りと処理
                //SqlDataReaderを閉じる
                sdr.Close();
            }
        }
    }
}
