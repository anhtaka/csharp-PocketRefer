using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6
{
    class TaskWaitAny
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task.WaitAnyサンプル開始");
            Task<double> task1 = Task.Run<double>(
                () => SampleMethods.HeavyWork2(10000000));
            Task<double> task2 = Task.Run<double>(
                () => SampleMethods.HeavyWork2(5000000));
            //現在のスレッドをブロックして待つ
            Task.WaitAny(task1, task2);
            //非同期メソッドの中では、awaitを使用してブロックせずに待つ
            //await Task.WhenAny(task1, task2);
            Console.WriteLine("1つのタスクが終了しました。");
            //完了していないタスクがあればResultで待つことになる
            Console.WriteLine("task2の結果{0}", task2.Result);
            Console.WriteLine("task1の結果{0}", task1.Result);
        }
    }
}