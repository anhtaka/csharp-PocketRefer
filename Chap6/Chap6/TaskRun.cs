using System;
using System.Threading.Tasks;

namespace Chap6
{
    class TaskRun
    {
        static void Main(string[] args)
        {
            Console.WriteLine("タスクを実行します。");
            //コンストラクタとStartメソッドを一度に呼び出す場合
            //RunまたはFactory.StartNew
            Task<double> task =
                Task.Run<double>(
                () => SampleMethods.HeavyWork2(10000000));
            //TaskCreationOptionsやTaskSchedulerを指定する場合は
            //Task.Factory.StartNewを使用する
            Task<double> task2 =
                Task.Factory.StartNew<double>(
                () => SampleMethods.HeavyWork2(15000000));
            //タスクが未完了の場合はResultプロパティは
            //メインスレッドをブロックする
            Console.WriteLine("task計算結果：{0}", task.Result);
            Console.WriteLine("task2計算結果：{0}", task2.Result);
        }
    }
}
