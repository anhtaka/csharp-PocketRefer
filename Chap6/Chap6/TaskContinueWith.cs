using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6
{
    class TaskContinueWith
    {
        static void Main(string[] args)
        {
            Task<double> task = 
                Task.Run<double>(() => SampleMethods.HeavyWork2(10000000));
            //タスクが完了した後に実行されるタスクを指定する
            task.ContinueWith((antecedent) =>
            {
                Console.WriteLine("taskの実行結果：{0}", antecedent.Result);
            },TaskScheduler.Default);
            //GUIアプリで、後続タスクで結果表示などでUIにアクセスする場合は
            //TaskScheduler.FromCurrentSynchronizationContext()が必要
            while (!task.IsCompleted)
            {
                Task.Delay(500).Wait();
                if (!task.IsCompleted) Console.WriteLine("...");
            }
        }
    }
}