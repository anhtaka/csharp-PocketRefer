using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Chap6
{
    class ThreadingTimer
    {
        static Timer timer;
        static int counter=0;
        static int n = 5;//繰り返し回数

        static void Main(string[] args)
        {
            //一定時間ごとに繰り返したい処理を表すデリゲート
            TimerCallback tc = new TimerCallback(Dowork);
            //実際には非同期処理で使用するパラメータをもつオブジェクトを渡す
            object state = new object();
            //2秒後に開始、1秒ごとに処理を繰り返す
            timer = new Timer(tc, state, 2000,1000);
            while (counter < n)
            {
                Thread.Sleep(250);
                Console.Write(".");
            }
        }
        
        static void Dowork(object state)
        {
            counter++;
            Console.Write(counter);
            //指定回数繰り返したらタイマーを破棄
            if (n <= counter)
                timer.Dispose();
        }

    }
}
