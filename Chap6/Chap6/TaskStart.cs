using System;
using System.Threading.Tasks;

namespace Chap6
{
    class TaskStart
    {
        static void Main(string[] args)
        {
            //HeavyWork1()は何らかの時間のかかる処理
            Task task = new Task(() => { SampleMethods.HeavyWork1();});
            //非同期処理を開始
            task.Start();

            Console.WriteLine("タスクは別のスレッドで実行されています。");
            task.Wait();
            Console.WriteLine("完了しました。");
        }
    }
}
