using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Chap7
{
    class SqlConnectionBeginTransactionConstructor
    {
        //接続文字列
        public static string connectionString =
            ConfigurationManager.ConnectionStrings["SQLEXP"].ConnectionString;
        static void Main(string[] args)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //コマンドオブジェクト
                SqlCommand command = conn.CreateCommand();

                //接続を開く
                conn.Open();

                Console.WriteLine("トランザクションを開始します。");
                //トランザクションオブジェクトを作成して開始する
                SqlTransaction transaction = conn.BeginTransaction();

                //トランザクションにコマンドを関連付ける
                command.Transaction = transaction;
                //既定の分離レベルを表示する
                Console.WriteLine("分離レベル:{0}",
                    transaction.IsolationLevel);
            }
        }
    }
}
