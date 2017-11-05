using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Chap7
{
    class SqlTransactionCommitRollback
    {
        //接続文字列
        public static string connectionString =
            ConfigurationManager.ConnectionStrings["SQLEXP"].ConnectionString;
        static void Main(string[] args)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //1つ目のクエリで使用するBOOK_IDの値
                string bookid = "000004";
                //コマンドオブジェクト
                SqlCommand command = conn.CreateCommand();
                //接続を開く
                conn.Open();
                //トランザクションオブジェクトを作成して開始する
                SqlTransaction transaction = conn.BeginTransaction();
                //トランザクションにコマンドを関連付ける
                command.Transaction = transaction;
                try
                {
                    //1つ目のINSERTクエリ
                    command.CommandText = @"INSERT INTO books VALUES "+ 
                    "(@newbookid,'ワームホール','科学',740,'2011-8-10')";
                    command.Parameters.AddWithValue("@newbookid", bookid);
                    Console.WriteLine("[{0}]を実行します。(@newbookid={1})", 
                        command.CommandText, bookid);
                    //1つ目のINSERTクエリ実行
                    command.ExecuteNonQuery();
                    Console.WriteLine("実行しました。");
                    //2つ目のINSERTクエリ
                    command.CommandText = @"INSERT INTO bookauthor "+
                                            "VALUES ('13',@newbookid)";
                    Console.WriteLine("[{0}]を実行します(@newbookid={1})",
                        command.CommandText, bookid);
                    //2つ目のINSERTクエリ実行
                    //authorsにAUTHOR_ID=13がないので失敗する
                    command.ExecuteNonQuery();
                    Console.WriteLine("実行しました。");
                    //コミットする
                    transaction.Commit();
                    Console.WriteLine("トランザクションをコミットしました");
                }
                catch (Exception ex1)
                {
                    Console.Error.WriteLine("  Message: {0}", ex1.Message);
                    try
                    {
                        //ロールバックする
                        transaction.Rollback();
                        Console.WriteLine(
                            "トランザクションをロールバックしました。");
                    }
                    catch (Exception ex2)
                    {
                        Console.Error.WriteLine(
                            "  Message: {0}", ex2.Message);
                    }
                }
                //ロールバックによって、1つ目のクエリも反映されていなことを確認
                command.CommandText
                    = "select count(*) from books where BOOK_ID=@newbookid";
                Console.WriteLine("[{0}]を実行します(@newbookid={1})",
                    command.CommandText, bookid);
                Console.WriteLine("BOOK_ID={0}のレコード数 {1} 件",
                    bookid, command.ExecuteScalar());
            }
        }
    }
}
