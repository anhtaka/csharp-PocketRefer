using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chap6
{
    class ThreadThreadStart
    {
        static void Main(string[] args)
        {
            //スレッドで非同期に行う処理を表すデリゲート
            ThreadStart ts = new ThreadStart(Dowork);
            //デリゲートを設定して、スレッドを作成
            Thread thread = new Thread(ts);
            //引数のデリゲートに関しては、
            //直接メソッド名、匿名メソッド、ラムダ式、も記述可能
            //さらにDowork();の部分はメソッド本体の直接記述も可能
            //Thread thread = new Thread(Dowork);
            //Thread thread = new Thread(delegate() { Dowork(); });
            //Thread thread = new Thread(()=> { Dowork(); });
            //スレッド開始
            thread.Start();
            Console.WriteLine("計算開始");
            //メインの処理では、スレッド処理の間"."を表示
            while (thread.ThreadState != ThreadState.Stopped)
            {
                Thread.Sleep(500);
                if (thread.ThreadState != ThreadState.Stopped)
                    Console.Write(".");
            }
            Console.WriteLine("処理終了");
        }
        //スレッドで行う重い処理(時間のかかる計算)
        static void Dowork() {
            int n = 300000000;
            double s = 0;
            for (int i = 0; i < n; i++)
            {
                s += ((i%2==0) ? 1 : -1) * 4 / (2 * (double)i + 1);
            }
            Console.WriteLine();
            Console.WriteLine(s);
        }
    }
}
