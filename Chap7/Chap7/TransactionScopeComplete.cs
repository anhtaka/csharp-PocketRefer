using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;

namespace Chap7
{
    class TransactionScopeComplete
    {
        //接続文字列
        public static string connectionString =
            ConfigurationManager.ConnectionStrings["SQLEXP"].ConnectionString;
        static void Main(string[] args)
        {
            //コードファイルの先頭にusing System.Transactions;を追加しておく
            //1つ目のクエリで使用するBOOK_IDの値
            string bookid = "000004";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = conn.CreateCommand();
                try
                {
                    using (TransactionScope ts = new TransactionScope())
                    {
                        conn.Open();
                        //1つ目のINSERTクエリ
                        command.CommandText = "INSERT INTO books VALUES "+
                        "(@newbookid,'ホワイトホール','科学',740,'2011-8-10')";
                        command.Parameters.AddWithValue(
                            "@newbookid", bookid);
                        Console.WriteLine(
                            "[{0}]を実行します(@newbookid={1})",
                            command.CommandText, bookid);
                        //1つ目のINSERTクエリ実行
                        command.ExecuteNonQuery();
                        Console.WriteLine("実行しました");
                        //2つ目のINSERTクエリ
                        command.CommandText = "INSERT INTO bookauthor " 
                                               +"VALUES ('13',@newbookid)";
                        Console.WriteLine(
                            "[{0}]を実行します(@newbookid={1})",
                            command.CommandText, bookid);
                        //2つ目のINSERTクエリ実行
                        //authorsにAUTHOR_ID=13がないので失敗する
                        command.ExecuteNonQuery();
                        Console.WriteLine("実行しました");
                        ts.Complete();
                        Console.WriteLine("正常に完了しました。");
                    }
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine("  Message: {0}", ex.Message);
                }
                //ロールバックによって、1つ目のクエリも反映されていなことを確認
                command.CommandText = 
                    "select count(*) from books where BOOK_ID=@newbookid";
                Console.WriteLine("[{0}]を実行します(@newbookid={1})",
                    command.CommandText, bookid);
                Console.WriteLine("BOOK_ID={0}のレコード数 {1} 件",
                    bookid, command.ExecuteScalar());
            }
        }
    }
}
