using System;
using System.Linq;
using System.Threading.Tasks;

namespace Chap6
{
    class 概要のサンプル_非同期
    {
        //出力用文字列
        static string text = string.Empty;

        //nが大きい数になると時間のかかる何らかの処理(非同期)
        private async static Task<double> HeavyWorkAsync(int n)
        {
            return await Task.Run(() =>
            Enumerable.Range(1, n)
                .Sum(i => 1 / (double)i) - Math.Log(n));
        }

        //文字列出力（非同期版）
        private async static Task ExecuteAsync()
        {
            text += ("計算開始") + Environment.NewLine;
            double result = await HeavyWorkAsync(200000000);
            text += result.ToString() + Environment.NewLine;
        }

        static void Main(string[] args)
        {
            //コンソールアプリケーションのMainの中では
            //直接awaitは使用できないため
            //Task.Runメソッドの中で、呼び出している
            Task task = Task.Run(async () =>
            {
                await ExecuteAsync();
            });
            //非同期であれば、時間のかかる処理を待っている間も
            //別の処理(たとえば、状態や進捗などを表示)が可能
            while (!task.IsCompleted)
            {
                OutputText(task);
            }
            Console.ReadKey();
        }
        //taskが終わっていなければ、計算中を示す「...」の行を追加
        private static void OutputText(Task task)
        {
            Task.Delay(1000).Wait();
            Console.SetCursorPosition(0, 0);
            if (!task.IsCompleted)
                text += "..." + Environment.NewLine;
            Console.WriteLine(text);
        }
    }
    class 概要のサンプル_同期
    {
        //出力用文字列
        static string text = string.Empty;

        //nが大きい数になると時間のかかる何らかの処理
        private static double HeavyWork(int n)
        {
            return Enumerable.Range(1, n)
                .Sum(i => 1 / (double)i) - Math.Log(n);
        }

        //テキスト出力
        private static void Execute()
        {
            text += ("計算開始") + Environment.NewLine;
            double result = HeavyWork(200000000);
            text += result.ToString() + Environment.NewLine;
        }

        static void Main(string[] args)
        {
            //結果を計算して、文字列に書き込むメソッド
            Execute();
            //「計算開始」と表示されるのは計算が終わった後
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}