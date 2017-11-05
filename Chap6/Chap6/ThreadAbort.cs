using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chap6
{
    class ThreadAbort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("キーを押すと中止します。");
            //時間のかかる処理
            Thread thread = new Thread(Dowork);
            thread.Start();
            while (thread.ThreadState == ThreadState.Running)
            {
                Thread.Sleep(500);
                //キーが押されたら
                if (Console.ReadKey().Key > 0)
                {
                    //スレッドを中止する
                    //引数のobjectはスレッドのcatchで使用できる
                    thread.Abort("スレッドを中止します。");
                }
            }
            Console.WriteLine($"スレッド状態:{thread.ThreadState}");
        }
        static void Dowork()
        {
            try
            {
                long a = 2432902008176640000L;
                long k = 100;
                for (long i = a; i < a + k; i++)
                {
                    Console.WriteLine($"{i} = {GetFactors(i)}");
                }
            }
            catch (ThreadAbortException ex)
            {
                //Abortの引数のobjectはExceptionStateプロパティに入っている
                Console.WriteLine(ex.ExceptionState);
            }
        }
        //nが大きい数だと時間がかかる処理
        public static string GetFactors(long n)
        {
            var sb = new StringBuilder();
            if (n <= 2) sb.Append(n);
            long d = 2;
            while (n > 2)
            {
                int i = 0;
                if (n < d * d) { sb.Append(n); break; }
                else while (n % d == 0) { n /= d; i++; }
                if (i > 0) sb.Append(d);
                if (i > 1) sb.AppendFormat("^{0}", i);
                if (i > 0 && n > 2) sb.Append("*");
                d = d > 2 ? d + 2 : 3;
            }
            return sb.ToString();
        }
    }
}
