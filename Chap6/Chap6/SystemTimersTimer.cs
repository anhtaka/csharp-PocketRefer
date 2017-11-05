using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chap6
{
    class SystemTimersTimer
    {
        static void Main(string[] args)
        {
            //マルチスレッドの確認のためにメインのマネージドスレッドIDを表示
            Console.WriteLine(
                $"Main ThreadId:{Thread.CurrentThread.ManagedThreadId}");
            //1秒ごとに、Elapsedイベントを発行するタイマーを作成
            //（ここでは、同じタイミングでイベントが起きる複数のタイマーを作成）
            System.Timers.Timer timer1 = new System.Timers.Timer(1000);
            System.Timers.Timer timer2 = new System.Timers.Timer(1000);
            //1秒ごとに行う処理をイベントハンドラーとして登録
            timer1.Elapsed += Timer_Elapsed;
            timer2.Elapsed += Timer_Elapsed;
            //イベントを繰り返す指定。既定値がtrueなので指定しなくてもよい
            timer1.AutoReset = true;
            //終了時刻を5秒後とする
            DateTime endTime = DateTime.Now.AddSeconds(5);
            //タイマーを開始する
            timer1.Start();
            timer2.Enabled = true;//Start()と同じ
            while (timer1.Enabled || timer2.Enabled)
            {
                Thread.Sleep(500);
                Console.WriteLine("... ... ...");
                //終了時刻になったらタイマーを止める
                if (endTime < DateTime.Now) { timer1.Stop(); timer2.Stop(); }
            }
        }
        //マネージドスレッドIDとイベント発生時刻を表示
        private static void Timer_Elapsed(
            object sender, System.Timers.ElapsedEventArgs e)
        {
            //sender にはtimerオブジェクトが入っている
            //var timer = sender as System.Timers.Timer;
            //ElapsedEventArgsにイベント発生時刻SignalTimeが入っている
            DateTime signalTime = e.SignalTime;
            Console.WriteLine(
                $"Timer ThreadId:{Thread.CurrentThread.ManagedThreadId}"
                    +$"({signalTime:HH:mm:ss}),");
        }
    }
}
