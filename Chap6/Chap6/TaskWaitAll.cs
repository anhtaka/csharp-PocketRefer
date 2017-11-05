using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6
{
    class TaskWaitAll
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task.WaitAllサンプル開始");
            Task<double> task1 = Task.Run<double>(
                () => SampleMethods.HeavyWork2(10000000));
            Task<double> task2 = Task.Run<double>(
                () => SampleMethods.HeavyWork2(5000000));
            //現在のスレッドをブロックして待つ
            Task.WaitAll(task1, task2);
            //非同期メソッドの中では、awaitを使用してブロックせずに待つ
            //await Task.WhenAll(task1, task2);
            Console.WriteLine("すべてのタスクが終了しました。");
            Console.WriteLine("task1の結果{0}", task1.Result);
            Console.WriteLine("task2の結果{0}", task2.Result);
        }
    }
}