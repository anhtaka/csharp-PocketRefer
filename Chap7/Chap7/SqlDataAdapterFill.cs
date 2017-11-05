using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Chap7
{
    class SqlDataAdapterFill
    {
        //接続文字列
        public static string connectionString =
            ConfigurationManager.ConnectionStrings["SQLEXP"].ConnectionString;
        static void Main(string[] args)
        {
            //データ取得のためのSQL文
            string sql = "select * from books;";
            //取得データ格納先のDataSet
            DataSet ds = new DataSet();
            //SqlConnectionオブジェクトの生成
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //SQL文と接続を引数としてSqlDataAdapterオブジェクトを作成
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                //データ取得
                int num = da.Fill(ds);
                Console.WriteLine("DataSetに取得した行数:\t{0}", num);
            }
        }
    }
}
