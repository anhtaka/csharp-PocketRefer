using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Chap5
{
    class TcpListenerNew
    {
        public static void Main(string[] args)
        {
            Main2(args).Wait();
        }

        public static async Task Main2(string[] args)
        {
            //ローカルのIPアドレスを作成
            IPAddress local = IPAddress.Parse("127.0.0.1");
            //ポート番号11111でリスナー作成
            TcpListener listener = new TcpListener(local,11111);
            //リッスン開始
            listener.Start();
            //TCPクライアントを取得
            TcpClient client = listener.AcceptTcpClient();

            //TCPクライアントを取得(非同期版)
            //TcpClient client = await listener.AcceptTcpClientAsync();

            //通信用のストリームを取得
            NetworkStream stream = client.GetStream();
            //書き込むデータ。Helloのバイト配列
            byte[] data = {0x48,0x65,0x6c,0x6c,0x6f};
            //TCPクライアントにメッセージを出力
            stream.Write(data, 0, data.Length);
            stream.Close();
            client.Close();
            listener.Stop();
            Console.ReadKey();
        }

    }
}
