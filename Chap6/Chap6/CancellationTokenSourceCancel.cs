using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chap6
{
    class CancellationTokenSourceCancel
    {
        static CancellationTokenSource cts = null;
        static void Main(string[] args)
        {
            Console.WriteLine("キー入力で処理を停止できます。");
            var mainTask = ExecuteAsync();
            //キー入力待ち
            Task.Run(() => {
                Console.ReadKey(true);
                //キーが押された場合タスクのキャンセルを要求する
                cts.Cancel();
            });
            mainTask.Wait();
        }

        private async static Task ExecuteAsync()
        {
            cts = new CancellationTokenSource();
            Task task = HeavyWorkCancellableAsync(
                100000000000000000L,100,cts.Token);
            try
            {
                await task;
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine("キャンセルされました。");
                Console.WriteLine(ex.Message);
                Console.WriteLine(task.Status);
            }
        }

        //キャンセル可能な非同期処理
        static async Task HeavyWorkCancellableAsync(
            long start, long count,CancellationToken token)
        {
            for (long i = start; i < start + count; i++)
            {
                //キャンセルが要求された場合に
                //OperationCanceledExceptionをスロー
                token.ThrowIfCancellationRequested();
                Console.WriteLine("{0} = {1}",
                    i,
                    await GetFactorsAsync(i,token));
            }
        }

        //非同期版、キャンセル可能
        public static async Task<string> GetFactorsAsync(
            long n, CancellationToken token)
        {
            return await Task.Run(() => {
                var sb = new StringBuilder();
                if (n <= 2) sb.Append(n);
                long d = 2;
                while (n > 2)
                {
                    //キャンセルが要求された場合に
                    //OperationCanceledExceptionをスロー
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
    }
}