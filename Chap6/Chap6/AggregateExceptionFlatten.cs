using System;
using System.Threading.Tasks;

namespace Chap6
{
    class AggregateExceptionFlatten
    {
        static void Main(string[] args)
        {
            //入れ子を含むタスクを実行
            Task t1 = Task.Run(() =>
            {
                Task t1_1 = Task.Run(() =>
                {
                    throw new Exception("t1_1で例外");
                });
                Task t1_2 = Task.Run(() =>
                {
                    throw new Exception("t1_2で例外");
                });
                Task.WaitAll(t1_1, t1_2);
            });
            //もう1つのタスクを実行
            Task t2 = Task.Run(() => { throw new Exception("t2で例外"); });
            try
            {
                //すべてのタスクの完了を待機
                Task.WaitAll(t1, t2);
            }
            catch (AggregateException ae)
            {
                //各非同期処理のスレッドで例外処理しなかった例外を
                //フラットにして、例外メッセージを表示
                //例外処理済みとしてtrueを返す
                ae.Flatten().Handle((ex) =>
                {
                    Console.WriteLine(ex.Message);
                    return true;
                });
            }
        }
    }
}