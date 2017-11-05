using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Chap7
{
    class SqlDataAdapterUpdate
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
                string localTableName = "booksTable";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                //SqlDataAdapterのUpadateメソッドで使用される
                //UpdateCommand等を自動生成するようにする
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                //データ取得
                da.Fill(ds, localTableName);
                //変更前の変更対象データを表示する
                string title = ds.Tables[localTableName]
                    .Rows[0]["TITLE"].ToString();
                Console.WriteLine("変更前:\t{0}", title);
                //ローカルのDataSetの1レコードを変更する
                ds.Tables[localTableName].Rows[0]["TITLE"] 
                    = title.Contains("1") ? title.Replace("11", "無限") 
                                          : title.Replace("無限", "11");
                //更新用クエリはUpdateの内部で自動生成され実行される
                da.Update(ds, localTableName);
                //再取得して変更されていることを確認する
                da.Fill(ds, localTableName);
                title = ds.Tables[localTableName]
                    .Rows[0]["TITLE"].ToString();
                Console.WriteLine("変更後:\t{0}", title);
            }
        }
    }
}
