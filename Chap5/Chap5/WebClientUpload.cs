using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;


namespace Chap5
{
    class WebClientUpload
    {
        public static void Main(string[] args)
        {
            Main2(args).Wait();
        }

        public static async Task Main2(string[] args)
        {
            WebClient client = new WebClient();
            //キー、値のコレクション
            NameValueCollection col = new NameValueCollection();
            col["name"] = "土井";
            col["city"] = "東京";
            //キー、値をPOST。文字コードはUTF-8としてエンコードされる
            //=や&などは自動的に送信される
            byte[] data = client.UploadValues(
               "http://localhost/postTest.aspx", col);

            //キー、値をPOST（非同期版）
            //byte[] data = await client.UploadValuesTaskAsync(
            //    "http://localhost/postTest.aspx", col);

            //EncodingプロパティにShift-JISエンコーディングを指定
            client.Encoding = Encoding.GetEncoding("shift-jis");
            //文字列をPOST。=や&などは自分で付ける必要がある
            string result = client.UploadString(
                "http://localhost/postTest.aspx", "name=土井&city=東京");

            //文字列をPOST（非同期版）
            //string result = await client.UploadStringTaskAsync(
            //  "http://localhost/postTest.aspx", "name=土井&city=東京");


            Console.ReadKey();
        }
    }
}
