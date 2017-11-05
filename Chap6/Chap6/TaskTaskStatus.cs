using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6
{
    class TaskTaskStatus
    {
        static void Main(string[] args)
        {
            Console.WriteLine("タスクステータスサンプル");
            Task<string> task = new Task<string>(
                ()=> SampleMethods.GetFactors(2432902008176640008L));
            //ステータスを表示
            Console.WriteLine("A:{0}", task.Status);
            task.Start();
            Console.WriteLine("B:{0}", task.Status);
            while (!task.IsCompleted)
            {
                Task.Delay(1000).Wait();
                Console.WriteLine("C:{0}", task.Status);
            }
            Console.WriteLine("D:{0}", task.Status);
            //正常終了した場合の結果表示
            if (task.Status == TaskStatus.RanToCompletion)
            {
                Console.WriteLine("taskの結果：{0}", task.Result);
            }
        }
    }
}