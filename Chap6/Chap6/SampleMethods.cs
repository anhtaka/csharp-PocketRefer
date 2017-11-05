using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chap6
{
    public partial class SampleMethods
    {
        public static void HeavyWork1() {
            long a = 2432902008176640000L;
            long k = 10;
            for (long i = a; i < a + k; i++)
            {
                Trace.WriteLine($"{i} = {GetFactors(i)}");
            }
        }

        public static double HeavyWork2(long n)
        {
            return GetApproximationOfPI(n);
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

        //非同期版、キャンセル可能
        public static async Task<string> GetFactorsAsync(long n, CancellationToken token) {
            return await Task.Run(()=> {
                var sb = new StringBuilder();
                if (n <= 2) sb.Append(n);
                long d = 2;
                while (n > 2)
                {
                    //キャンセルが要求された場合にOperationCanceledExceptionをスロー
                    token.ThrowIfCancellationRequested();
                    int i = 0;
                    if (n < d * d) { sb.Append(n); break; }
                    else while (n % d == 0) { n /= d; i++; }
                    if (i > 0) sb.Append(d);
                    if (i > 1) sb.AppendFormat("^{0}", i);
                    if (i > 0 && n > 2) sb.Append("*");
                    d = d > 2 ? d + 2 : 3;
                }
                return sb.ToString();
            });
        }

        private static double GetApproximationOfPI(long n)
        {
            Random random = new Random(Environment.TickCount);
            long sum = 0;
            for (long i = 1; i <= n; i++)
            {
                if (GCD(random.Next(), random.Next()) == 1)
                {
                    sum += 1;
                }
            }
            return Math.Sqrt(6d * n / sum);
        }
        public static long GCD(long x, long y)
        {
            long z = 0;
            while (y > 0) { z = y; y = x % y; x = z; }
            return x;
        }

    }
}
