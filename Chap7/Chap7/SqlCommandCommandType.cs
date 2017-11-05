using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Chap7
{
    class SqlCommandCommandType
    {
        //接続文字列
        public static string connectionString =
            ConfigurationManager.ConnectionStrings["SQLEXP"].ConnectionString;
        static void Main(string[] args)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //SqlConnection.CreateCommandでも新たなSqlCommandを作成できる
                SqlCommand cmd = conn.CreateCommand();
                // コマンドの種類をストアドプロシージャに設定
                cmd.CommandType = CommandType.StoredProcedure;
                //ストアドプロシージャ名
                cmd.CommandText = "GetBooksWithinBudget";
                Console.WriteLine("正の数字を入力してください。");
                Console.Write("所持金=");
                long mymoney;
                long.TryParse(Console.ReadLine(), out mymoney);
                cmd.Parameters.AddWithValue("@mymoney", mymoney);
                conn.Open();
                //結果を取得する
                SqlDataReader sdr = cmd.ExecuteReader();
                Console.WriteLine((sdr.HasRows) ? "以下の書籍が購入可能です。" 
                                                : "購入可能な本はありません。");
                //結果を1行ずつ読み取る
                while (sdr.Read())
                {
                    //フィールド名により値を取得
                    Console.WriteLine("{0}著「{1}」,{2:￥0}", 
                        sdr["AUTHORS"], sdr["TITLE"], sdr["PRICE"]);
                }
                sdr.Close();
            }
        }
    }
}
