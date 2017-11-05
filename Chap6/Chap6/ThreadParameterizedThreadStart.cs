using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chap6
{
    //処理の引数オブジェクトとして使用
    class MyParameter
    {
        public int N { get; set; }
        public double ReturnValue { get; set; }
    }
    class ThreadParameterizedThreadStart
    {
        static void Main(string[] args)
        {
            //スレッドで非同期に行う処理を表すデリゲート
            ParameterizedThreadStart pts 
                = new ParameterizedThreadStart(Dowork);
            //デリゲートを設定して、スレッドを作成
            Thread thread = new Thread(pts);
            //引数のデリゲートに関しては、
            //直接メソッド名、匿名メソッド、ラムダ式、も記述可能
            //さらにDowork();の部分はメソッド本体の直接記述も可能
            //Thread thread = new Thread(Dowork);
            //Thread thread 
            //    = new Thread(delegate(object n) { Dowork(n); });
            //Thread thread = new Thread((n)=>Dowork(n));
            //処理の引数と戻り値を格納するためのオブジェクト
            MyParameter p = new MyParameter();
            p.N = 500000000;
            //スレッド開始
            thread.Start(p);
            Console.WriteLine("処理開始");
            //メインの処理では、スレッド処理の間"."を表示
            while (thread.ThreadState != ThreadState.Stopped)
            {
                Thread.Sleep(500);
                if (thread.ThreadState != ThreadState.Stopped)
                    Console.Write(".");
            }
            Console.WriteLine();
            //引数オブジェクトに格納されている結果を表示
            Console.WriteLine($"計算結果={p.ReturnValue}");
        }
        //スレッドで行う重い処理(時間のかかる計算)
        static void Dowork(object obj)
        {
            MyParameter p = obj as MyParameter;
            int n = p.N;
            double s = 0;
            Console.WriteLine($"n={n}");
            for (int i = 0; i < n; i++)
            {
                s += ((i % 2 == 0) ? 1 : -1) * 4 / (2 * (double)i + 1);
            }
            //引数のオブジェクトの戻り値用メンバに結果を格納
            p.ReturnValue = s;
        }
    }
}
