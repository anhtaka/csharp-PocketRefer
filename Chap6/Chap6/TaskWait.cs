using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6
{
    class TaskWait
    {
        static void Main(string[] args)
        {
            Console.WriteLine("計算開始");
            Task<double> task = Task.Run<double>(
                () => SampleMethods.HeavyWork2(10000000));
            //非同期メソッドの中では
            //double result = await task;
            //として、その後に後続処理を書ける
            task.Wait();
            double result = task.Result; 
            Console.WriteLine("計算結果：{0}", result);
        }
    }
}