using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Chap7
{
    class SqlParameterDirection
    {
        //接続文字列
        public static string connectionString =
            ConfigurationManager.ConnectionStrings["SQLEXP"].ConnectionString;
        static void Main(string[] args)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                //ストアドプロシージャ名
                cmd.CommandText = "AddBook";
                //AddWithValueのほかにAddによるSqlParameterの追加方法もある
                cmd.Parameters.Add("@book_id", SqlDbType.VarChar).Value
                    = "400002";
                cmd.Parameters.Add("@book_title", SqlDbType.VarChar).Value
                    = "異次元旅行記";
                cmd.Parameters.Add("@book_type", SqlDbType.Char).Value
                    = "小説";
                cmd.Parameters.AddWithValue("@book_price", 1200);
                cmd.Parameters.AddWithValue("@book_pubdate",
                                            new DateTime(2015, 12, 31));
                //引数なしのSqlParameterコンストラクタ
                SqlParameter output_param = new SqlParameter();
                output_param.ParameterName = "@sum_of_book_prices";
                output_param.SqlDbType = SqlDbType.Money;
                //出力パラメーターの指定
                output_param.Direction = ParameterDirection.Output;
                //SqlCommandのParametersにSqlParameterオブジェクトを追加
                cmd.Parameters.Add(output_param);
                //引数でプロパティ指定するSqlParameterコンストラクタ
                SqlParameter returnvalue_param =
                    new SqlParameter("@count_of_books", SqlDbType.Int);
                //戻り値の指定
                returnvalue_param.Direction
                    = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(returnvalue_param);
                conn.Open();
                try
                {
                    //実行
                    int l = cmd.ExecuteNonQuery();
                    Console.WriteLine("{0}行処理しました。", l);
                    Console.WriteLine("{0}冊の本が登録されました。",
                        cmd.Parameters["@count_of_books"].Value);
                    Console.WriteLine("1冊ずつの合計金額は{0:￥0}です。",
                        cmd.Parameters["@sum_of_book_prices"].Value);
                }
                catch (SqlException sqlex)
                {
                    foreach (SqlError error in sqlex.Errors)
                    {
                        Console.WriteLine("エラー番号:{0}, {1}",
                            error.Number, error.Message);
                    }
                }
            }
        }
    }
}
