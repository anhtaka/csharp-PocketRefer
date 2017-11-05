using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6
{
    class TaskTResult
    {
        static void Main(string[] args)
        {
            //HeavyWork2()は何らかの時間のかかる処理
            Task<double> task = new Task<double>(() =>
            SampleMethods.HeavyWork2(10000000L));
            //非同期処理を開始
            task.Start();
            Console.WriteLine("タスクは別のスレッドで実行されています。");
            while (!task.IsCompleted)
            {
                //タスクが完了するまでメインでは別の処理を行える
                Task.Delay(500).Wait();
                Console.Write(".");
            }
            //結果をResultプロパティで取得
            double result = task.Result;
            Console.WriteLine("完了しました。");
            Console.WriteLine($"計算結果={result}");
        }
    }
}
