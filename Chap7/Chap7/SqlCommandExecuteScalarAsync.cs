using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Chap7
{
    class SqlCommandExecuteScalarAsync
    {
        //接続文字列
        public static string connectionString =
            ConfigurationManager.ConnectionStrings["SQLEXP"].ConnectionString;
        static void Main(string[] args)
        {
            //SQLクエリ文
            string sql = "SELECT COUNT(*) FROM books;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                //コードファイルの先頭にusing System.Threading.Tasks;があること
                Task<object> task = cmd.ExecuteScalarAsync();
                if (task.Status != TaskStatus.RanToCompletion)
                {
                    Console.WriteLine("結果取得待ち");
                }
                int x = (int)task.Result;
                Console.WriteLine("登録されている本のタイトル数は {0} です", x);
            }
        }
    }
}
