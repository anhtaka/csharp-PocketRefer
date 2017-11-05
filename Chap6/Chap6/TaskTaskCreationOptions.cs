using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6
{
    class TaskTaskCreationOptions
    {
        static void Main(string[] args)
        {
            //親タスク
            var parentTask = new Task(() =>
                {
                    //入れ子になったタスク
                    var nestedTask = new Task(() =>
                        {
                            SampleMethods.HeavyWork2(5000000);
                            Console.WriteLine("入れ子タスク(A)完了");
                        }
                    );
                    //子タスク
                    nestedTask.Start();
                    //TaskCreationOptions.AttachedToParentを指定して
                    //子タスクとして作成
                    var childTask = new Task(() =>
                        {
                            SampleMethods.HeavyWork2(1000000);
                            Console.WriteLine("子タスク(B)完了");
                        }, TaskCreationOptions.AttachedToParent 
                    );
                    childTask.Start();
                }
                //DenyChildAttachを指定すると子タスクの
                //AttachedToParentは無効になる
                //,TaskCreationOptions.DenyChildAttach 
                );
            parentTask.Start();
            while (!parentTask.IsCompleted)
            {
                //完了を待つ
            }
            //単なる入れ子タスクの場合、親タスクは入れ子タスクを待たない
            //親子関係がある場合、親タスクは子タスクの完了を待ってから終了する
            Console.WriteLine("親タスク(C)完了");
            //入れ子タスク(A)を3秒は待つ(Aは3秒以内に完了するとは限らない)
            Task.Delay(3000).Wait();
            //一般に(A)に関しては、(B)より早く完了する場合も、
            //(B)と(C)の間の可能性もある。
        }
    }
}
