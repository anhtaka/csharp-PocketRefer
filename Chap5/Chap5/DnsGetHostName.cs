using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Chap5
{
    class DnsGetHostName
    {
        public static void Main(string[] args)
        {
            string hostName = Dns.GetHostName();
            Console.WriteLine("ローカルコンピュータのホスト名:" + hostName);
            Console.ReadKey();
        }
    }
}
