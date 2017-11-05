using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Chap7
{
    class SqlCommandBuilderConstructor
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
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                Console.WriteLine("設定したSELECT文:\t{0}",
                    da.SelectCommand.CommandText);

                //SqlDataAdapterのUpdateCommandを自動生成するようにする
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                Console.WriteLine("自動生成されるUPDATE文:\t{0}",
                    builder.GetUpdateCommand().CommandText);

                Console.WriteLine("自動生成されるINSERT文:\t{0}",
                    builder.GetInsertCommand().CommandText);

                //列名をパラメータ名としたSQL文を生成
                Console.WriteLine("自動生成されるDELETE文:\t{0}",
                    builder.GetDeleteCommand(true).CommandText);
            }
        }
    }
}
