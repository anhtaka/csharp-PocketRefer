using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Chap7
{
    class DataSetTablesRows
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
                //ds.Tablesをループして1つ1つDataTableを取り出す
                foreach (DataTable table in ds.Tables)
                {
                    //table.Rowsをループして1つ1つDataRowを取り出す
                    foreach (DataRow row in table.Rows)
                    {
                        //table.Columnsをループして1つ1つDataColumnを取り出す
                        foreach (DataColumn col in table.Columns)
                        {
                            //フィールド名を表示
                            Console.Write("{0}", col.ColumnName);
                            //NULL値でないことを確認して値を表示する
                            if (!row.IsNull(col))
                            {
                                Console.WriteLine("\t{0}", row[col]);
                            }
                        }
                        Console.WriteLine("-------------------------");
                    }
                }
            }
        }
    }
}
