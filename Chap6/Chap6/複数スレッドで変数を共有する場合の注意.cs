using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6
{
    class 複数スレッドで変数を共有する場合の注意
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(CountIntegers());
            }
            Console.WriteLine("以下のメソッドではlockを使用");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(CountIntegersFixed());
            }
        }
        static int CountIntegers()
        {
            int count = 0;
            var tasksQuery = Enumerable.Range(1, 10000)
                .Select(i => 
                    Task.Run(() =>
                    {
                        count++;
                    })
                );
            Task.WaitAll(tasksQuery.ToArray());
            return count;
        }
        static int CountIntegersFixed()
        {
            int count = 0;
            //ロックのためのオブジェクト
            var lockObj = new object();
            var tasksQuery = Enumerable.Range(1, 10000)
                .Select(i =>
                    Task.Run(() =>
                    {
                        //インクリメントの間排他制御
                        lock (lockObj) { 
                            count++;
                        }
                    })
                );
            Task.WaitAll(tasksQuery.ToArray());
            return count;
        }
    }
}