using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Chap6
{
    class 条件によって完了済みタスクを返す
    {
        static void Main(string[] args)
        {
            var task = GetHeavyWorkTask(100000000000000003L);
            while (!task.IsCompleted)
            {
                Task.Delay(1000).Wait();
                Console.WriteLine("...");
            }
            Console.WriteLine(task.Result);
            task = GetHeavyWorkTask(100000000000000003L);
            Console.WriteLine("--------------");
            Console.WriteLine(task.Result);
            Console.WriteLine("--------------");
            try
            {
                Console.WriteLine(GetHeavyWorkTask(-100L).Result);
            }
            catch (AggregateException ex)
            {
                ex.Handle(ex1 =>
                {
                    Console.WriteLine(ex1.Message);
                    return true;
                });
            }
        }
        public static Task<string> GetHeavyWorkTask_0(long n)
        {
            return Task.Run(() => GetFactors(n));
        }

        static Dictionary<long, string> cacheDictionary = new Dictionary<long, string>();
        static Task<string> GetHeavyWorkTask(long n)
        {
            if (n <= 0)
                return Task.FromException<string>(new ArgumentException());
            if (cacheDictionary.ContainsKey(n))
                return Task.FromResult(cacheDictionary[n]);
            return Task.Run(() =>
            {
                string result = GetFactors(n);
                cacheDictionary.Add(n, result);
                return result;
            });
        }

        //nが大きい数だと時間がかかる処理
        public static string GetFactors(long n)
        {
            var sb = new StringBuilder();
            if (n <= 2) sb.Append(n);
            long d = 2;
            while (n > 2)
            {
                int i = 0;
                if (n < d * d) { sb.Append(n); break; }
                else while (n % d == 0) { n /= d; i++; }
                if (i > 0) sb.Append(d);
                if (i > 1) sb.AppendFormat("^{0}", i);
                if (i > 0 && n > 2) sb.Append("*");
                d = d > 2 ? d + 2 : 3;
            }
            return sb.ToString();
        }
    }
}
