using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Chap5
{
    class DnsGetHostAddresses
    {
        public static void Main(string[] args)
        {
            //ホスト名を取得
            string hostName = Dns.GetHostName();

            //IPアドレス一覧を取得
            IPAddress[] addresses = Dns.GetHostAddresses(hostName);
            foreach (IPAddress address in addresses)
            {
                Console.WriteLine("アドレス表記:" + address.ToString());

                //IPアドレスのバイト配列を,を挟んで出力
                Console.WriteLine(
                    "バイト列:{0}\n" , string.Join(",", address.GetAddressBytes()));
            }

            Console.ReadKey();
        }
    }
}
