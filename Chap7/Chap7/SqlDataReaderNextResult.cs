using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Chap7
{
    class SqlDataReaderNextResult
    {
        //接続文字列
        public static string connectionString =
            ConfigurationManager.ConnectionStrings["SQLEXP"].ConnectionString;
        static void Main(string[] args)
        {
            //SQLクエリ文
            string sql = @"SELECT * FROM books;
				   SELECT * FROM authors";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //クエリに対応するオブジェクトを生成する
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                //結果を取得する
                SqlDataReader sdr = cmd.ExecuteReader();
                //結果データが複数ある場合にdo...while (sdr.NextResult());で繰り返す
                do
                {
                    //フィールドの数
                    int fcount = sdr.FieldCount;
                    for (int i = 0; i < fcount; i++)
                    {
                        //フィールドの名前を取得
                        Console.Write("{0}\t", sdr.GetName(i));
                    }
                    Console.WriteLine();
                    //結果を1行ずつ読み取る
                    while (sdr.Read())
                    {
                        for (int i = 0; i < fcount; i++)
                        {
                            //フィールド番号により値を取得する
                            Console.Write("{0}\t", sdr[i]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                } while (sdr.NextResult());
                sdr.Close();
            }
        }
    }
}
