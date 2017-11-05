using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chap6
{
    class 完了通知のある非同期処理のタスク化
    {
        //完了通知のある非同期処理をラップしてTask<string>にする
        public static Task<string> DoWorkTask(int i)
        {
            var tcs = new TaskCompletionSource<string>();
            var worker = new MyWorker<int, string>(Work);
            if (i >= 0)
            {
                worker.Completed += (result) =>
                {
                    //完了時に結果をセット
                    tcs.SetResult(result);
                };
                worker.Start(i);
            }
            else
            {
                //例外をセットすることもできる
                tcs.SetException(new ArgumentException());
            }
            return tcs.Task;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("別スレッドで処理を行うクラスMyWorker");
            //引数で指定したメソッドを別スレッドで行うクラス
            var worker = new MyWorker<int, string>(Work);
            //結果を処理する完了イベントハンドラーを設定
            worker.Completed += result => Console.WriteLine(result);
            //処理を開始
            worker.Start(1);
            //待機中の処理 
            while (!worker.IsCompleted)
            {
                Thread.Sleep(1000);
                if (!worker.IsCompleted)
                    Console.WriteLine("...");
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("MyWorkerをTask<T>でラップして実行");
            Task<string> task = DoWorkTask(10);
            while (!task.IsCompleted)
            {
                Task.Delay(1000).Wait();
                Console.WriteLine("...");
            }
            try
            {
                Console.WriteLine(task.GetAwaiter().GetResult());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("例外をセットするサンプル");
            task = DoWorkTask(-1);
            while (!task.IsCompleted)
            {
                Task.Delay(1000).Wait();
                Console.WriteLine("...");
            }
            try
            {
                Console.WriteLine(task.GetAwaiter().GetResult());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //何らかの時間のかかる処理
        //このサンプルでは、単に3秒待機して、
        //引数に1足して、結果の文字列を作成している
        public static string Work(int i)
        {
            Thread.Sleep(3000);
            return string.Format($"結果 : {i + 1}");
        }
    }

    //完了イベントハンドラーデリゲート
    public delegate void CompletedEventHandler<TResult>(TResult result);
    //別スレッドで処理を行うクラスMyWorkerを実装
    //例えば、Threadを使って実装
    public class MyWorker<T, TResult>
    {
        //完了イベント
        public event CompletedEventHandler<TResult> Completed;
        public bool IsCompleted { get; private set; }
        Func<T, TResult> workmethod;
        //コンストラクタ引数で、処理を設定
        public MyWorker(Func<T, TResult> workMethod)
        {
            this.workmethod = workMethod;
        }
        //開始
        public void Start(T arg)
        {
            Thread thread = new Thread(() => {
                Completed(workmethod(arg));
                IsCompleted = true;
            });
            thread.Start();
        }
        
    }
}