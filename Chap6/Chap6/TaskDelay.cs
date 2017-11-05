using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6
{
    class TaskDelay
    {
        static void Main(string[] args)
        {
            Console.WriteLine("開始");
            //指定時間経過後に終了するタスクをスケジュールして開始
            Task task = Task.Delay(3000);
            task.ContinueWith((_) =>
            {
                Console.WriteLine("3秒経過しました。");
            }, TaskScheduler.Current);
            while (!task.IsCompleted)
            {
                Task.Delay(1000).Wait();
                if (!task.IsCompleted) Console.WriteLine("...");
            }
        }
    }
}