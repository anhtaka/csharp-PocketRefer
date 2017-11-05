using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;

namespace Chap7
{
    class SqlDataReaderNextResultAsync
    {
        //接続文字列
        public static string connectionString =
            ConfigurationManager.ConnectionStrings["SQLEXP"].ConnectionString;
        static void Main(string[] args)
        {
            Task task = MainTaskAsync();
            if (task.Status != TaskStatus.RanToCompletion)
                Console.WriteLine("結果を待機");
            while (task.Status != TaskStatus.RanToCompletion)
            {
                //待機中にここを通ることがあることを確認するために文字色を変更
                Console.ForegroundColor = (Console.ForegroundColor == ConsoleColor.Gray) ? ConsoleColor.Yellow : ConsoleColor.Gray;
            }
        }

        static async Task MainTaskAsync()
        {
            //SQLクエリ文
            string sql = @"SELECT * FROM books;
				   SELECT * FROM authors";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //クエリに対応するオブジェクトを生成する
                SqlCommand cmd = new SqlCommand(sql, conn);
                await conn.OpenAsync();
                //結果を取得する
                SqlDataReader sdr = await cmd.ExecuteReaderAsync();
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
                    while (await sdr.ReadAsync())
                    {
                        for (int i = 0; i < fcount; i++)
                        {
                            //フィールド番号により値を取得する
                            Console.Write("{0}\t", sdr[i]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                } while (await sdr.NextResultAsync());
                sdr.Close();
            }
        }
    }
}
