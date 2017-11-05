using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Chap5
{
    //マルチスレッドでTCPリスナーとTCPクライアントを同時実行するサンプル
    class TcpListenerClientTest
    {
        delegate void ClientDelegate(string[] args);

        public static void Main(string[] args)
        {
            ClientDelegate clientDelegate = new ClientDelegate(Main2);
            clientDelegate.BeginInvoke(null, null, null);

            //ローカルのIPアドレスを作成
            IPAddress local = IPAddress.Parse("192.168.0.9");
            //ポート番号11111でリスナー作成
            TcpListener listener = new TcpListener(local, 11111);
            //リッスン開始
            listener.Start();
            //TCPクライアントを取得
            TcpClient client = listener.AcceptTcpClient();

            //通信用のストリームを取得
            NetworkStream stream = client.GetStream();
            //書き込むデータ。Helloのバイト配列
            byte[] data = { 0x48, 0x65, 0x6c, 0x6c, 0x6f };
            //TCPクライアントにメッセージを出力
            stream.Write(data, 0, data.Length);
            stream.Close();
            client.Close();
            listener.Stop();
            Console.ReadKey();
        }

        public static void Main2(string[] args)
        {
            //TCPクライアント作成
            TcpClient client = new TcpClient();
            //192.168.0.9のポート11111に接続
            client.Connect("192.168.0.9", 11111);
            NetworkStream stream = client.GetStream();
            byte[] data = new byte[10];
            stream.Read(data, 0, data.Length);
            Console.WriteLine("TCPリスナーからのデータ:" + Encoding.ASCII.GetString(data));
            Console.ReadKey();
        }
    }
}
