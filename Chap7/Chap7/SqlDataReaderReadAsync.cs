using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;

namespace Chap7
{
    class SqlDataReaderReadAsync
    {
        //接続文字列
        public static string connectionString =
            ConfigurationManager.ConnectionStrings["SQLEXP"].ConnectionString;

        static async Task MainTaskAsync()
        {
            //SQLクエリ文
            string sql = "SELECT TITLE,TYPE,PRICE FROM books;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //クエリに対応するオブジェクトを生成する。
                SqlCommand cmd = new SqlCommand(sql, conn);
                await conn.OpenAsync();
                //結果を取得する
                SqlDataReader sdr = await cmd.ExecuteReaderAsync();
                //フィールド名
                Console.WriteLine("TITLE\tTYPE\tPRICE");
                //結果を1行ずつ読み取る
                while (await sdr.ReadAsync())
                {
                    //フィールド名により値を取得
                    Console.WriteLine("{0}\t{1}\t{2}",
                        sdr["TITLE"], sdr["TYPE"], sdr["PRICE"]);
                }
                //SqlDataReaderを閉じる
                sdr.Close();
            }
        }
        static void Main(string[] args)
        {
            var task = MainTaskAsync();
            if (task.Status != TaskStatus.RanToCompletion)
                Console.WriteLine("結果を待機");
            while (task.Status != TaskStatus.RanToCompletion)
            {
                //待機中にここを通ることがあることを確認するために文字色を変更
                Console.ForegroundColor =
                    (Console.ForegroundColor == ConsoleColor.Gray) 
                    ? ConsoleColor.Yellow : ConsoleColor.Gray;
            }
        }


    }
}
