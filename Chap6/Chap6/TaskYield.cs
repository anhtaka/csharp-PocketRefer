using System;
using System.Threading.Tasks;

namespace Chap6
{
    class TaskYield
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yieldを使用");
            Execute(true).Wait();
            Console.WriteLine("--------------------");
            Console.WriteLine("Yieldを不使用");
            Execute(false).Wait();
        }
        static async Task Execute(bool useYield)
        {
            Task<long> task = HeavyWorkAsync(3000000, useYield);
            while (!task.IsCompleted)
            {
                await Task.Delay(500);
                //制御が戻ってきていればここを通る
                Console.Write(".");
            }
            Console.WriteLine();
            Console.WriteLine($"計算結果：{task.Result}");
        }
        static async Task<long> HeavyWorkAsync(long n, bool useYield)
        {
            long count = 0;
            for (long i = 2; i <= n; i += (i > 2) ? 2 : 1)
            {
                if (useYield && (i - 1) % 10 == 0)
                    await Task.Yield();//制御を呼び出し元に返す
                if (IsPrime(i))
                    count++;
            }
            return count;
        }
        public static bool IsPrime(long i)
        {
            if (i < 2) return false;
            long j;
            for (j = 2; j * j <= i; j += (j > 2) ? 2 : 1)
            {
                if (i % j == 0)
                {
                    break;
                }
            }
            return (j * j > i);
        }
    }
}