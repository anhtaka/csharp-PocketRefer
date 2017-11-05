using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Chap6
{
    class ThreadingAutoResetEvent
    {
        static AutoResetEvent arEvent;
        static int oddNumber = 0;
        static int n = 10;
        static void Main(string[] args)
        {
            arEvent = new AutoResetEvent(false);
            Thread thread1 = new Thread(Dowork1);
            Thread thread2 = new Thread(Dowork2);
            thread1.Start();
            thread2.Start();
            while (thread1.ThreadState != ThreadState.Stopped)
            {
                Thread.Sleep(500);
                Console.WriteLine("...");
            }
        }
        static void Dowork1()
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Dowork1:処理中");
                //時間のかかる計算の代わりにThread.Sleep
                Thread.Sleep(500);
                oddNumber = 2 * i - 1;
                Console.WriteLine($"Dowork1:{i}番目の奇数={oddNumber}");
                //待機解除を通知
                arEvent.Set();
                //このスレッドの処理が次のoddNumberの値を書き込む前に、
                //Dpwork2が動作できるようにこのスレッドをブロック
                Thread.Sleep(10);
            }
        }
        static void Dowork2() {
            int sum = 0;
            while (oddNumber<2*n-1)
            {
                Console.WriteLine("Dowork2: Dowork1の処理待ち");
                //Dowork1が奇数を書き込むまで待機
                arEvent.WaitOne();
                sum += oddNumber;
                Console.WriteLine(
                    $"Dowork2:奇数{oddNumber}までの奇数和={sum}");
                Console.WriteLine("-------------------");
            }
        }
    }
}
