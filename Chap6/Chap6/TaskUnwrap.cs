using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6
{
    class TaskUnwrap
    {
        static void Main(string[] args)
        {
            int n = 7000;
            var task = Task.Run<IEnumerable<int>>(() =>
                Enumerable.Range(1, n)
                  .Select(m =>
                    Enumerable.Range(1, m)
                    .Count(k => SampleMethods.GCD(k, m) == 1)));
            var task2 = task.ContinueWith((task1) =>
                    Task<int>.Run(() =>
                    Math.Sqrt(3d * n * n / (double)task1.Result.Sum())));
            var unwraped_task2 = task2.Unwrap();
            unwraped_task2.Wait();
            //task2はTask<Task<double>>型であり待機してもdoubleにならない
            Console.WriteLine("task2の結果：{0}", task2.Result);
            Console.WriteLine("Unwrapしたtask2の結果：{0}"
                , unwraped_task2.Result);
        }
    }
}