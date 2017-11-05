using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Chap6
{
    class ProgressReport
    {        
        static void Main(string[] args)
        {
            var cts = new CancellationTokenSource();
            //System.Progress<T>オブジェクト
            //報告を受け取った時の処理
            var progress = new Progress<byte>(p =>
            {
                statusLine = $"{p:0}%";
                if (p == 100) {
                    statusLine += " 完了"; UpdateConsole(); }
            });
            //ProgressChangedハンドラーに追加も可能
            //progress.ProgressChanged += (sender,p)=> { ... };
            var mainTask = HeavyWorkWithProgressAsync(
                100000000000, 10000, cts.Token, progress);
            Task.Run(() => {
                Console.ReadKey(true);
                cts.Cancel();
            });
            while (!mainTask.IsCompleted)
            {
                UpdateConsole();
                Task.Delay(250).Wait();
            }
        }

        private async static Task HeavyWorkWithProgressAsync(
            long start, long n,
            CancellationToken token,
            IProgress<byte> progress)
        {
            try
            {
                byte interval = 1;
                for (long i = start; i <= start + n; i++)
                {
                    token.ThrowIfCancellationRequested();
                    if ((i - start) % (n * interval / 100) == 0)
                    {
                        //進捗を報告する
                        progress.Report((byte)((i - start) * 100 / n));
                    }
                    WriteLine("{0} = {1}",
                        i,
                        await SampleMethods.GetFactorsAsync(i, token));
                }
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //コンソールの一行目にステータス表示用バッファー
        static string statusLine = string.Empty;
        //出力用のバッファー
        static List<string> output = new List<string>();
        //バッファーへの出力
        static void WriteLine(string format, params object[] args)
        {
            while (output.Count > Console.WindowHeight - 3)
            {
                output.RemoveAt(0);
            }
            output.Add(string.Format(format, args));
        }
        //ステータス行とバッファーをコンソールに出力
        private static void UpdateConsole()
        {
            Console.Clear();
            Console.WriteLine(statusLine);
            for (int i = 0; i < output.Count; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}