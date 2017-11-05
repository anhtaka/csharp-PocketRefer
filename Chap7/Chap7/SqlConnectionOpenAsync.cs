using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Chap7
{
    class SqlConnectionOpenAsync
    {
        static void Main(string[] args)
        {
            //接続文字列
            string connectionString = @"Data Source=.\SQLEXPRESS;
	        Initial Catalog=pr_cs_sampleDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                Console.WriteLine("非同期接続開始");
                //接続を開く 
                //コードファイルの先頭にusing System.Threading.Tasks;があれば、
                //System.Threading.Tasks.TaskをTaskと記述できる。
                Task t = conn.OpenAsync();
                if (conn.State != System.Data.ConnectionState.Open)
                    Console.WriteLine("State={0}", conn.State);
                t.Wait();
                Console.WriteLine("データベースに接続しました。State={0}"
                    , conn.State);
                //データベースへのクエリなどを実行する。
            }
        }
    }
}
