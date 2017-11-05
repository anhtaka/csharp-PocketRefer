using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Chap5
{
    class TcpClientNew
    {
        public static void Main(string[] args)
        {
            Main2(args).Wait();
        }

        public static async Task Main2(string[] args)
        {
            //TCPクライアント作成
            TcpClient client = new TcpClient();

            //192.168.0.9のポート11111に接続
            client.Connect("192.168.0.9", 11111);

            //192.168.0.9のポート11111に接続(非同期版)
            //await client.ConnectAsync("192.168.0.9", 11111);

            //ネットワーク用のストリームを作成
            NetworkStream stream = client.GetStream();

            //読み込み用バッファ
            byte[] data = new byte[10];

            //ネットワークからストリームとしてデータ読み込み
            stream.Read(data, 0, data.Length);

            Console.WriteLine(
                "TCPリスナーからのデータ:" + Encoding.ASCII.GetString(data));
            Console.ReadKey();
        }
    }
}
