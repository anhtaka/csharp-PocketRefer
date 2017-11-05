using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    // デリゲート定義
    delegate void SampleEventHandler();

    class DelegateEvent
    {
        // eventの宣言と初期化
        public event SampleEventHandler EventEven;

        // 1～5を表示。ただし偶数のときはイベントが発生する
        public void Sample()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.Write(i);
                if (i % 2 == 0)
                {
                    // イベントを発生させる（イベントハンドラの呼び出し）
                    EventEven();
                }
            }
        }
        public static void Main()
        {
            DelegateEvent t = new DelegateEvent();

            // イベントハンドラの定義
            t.EventEven = () => Console.Write("偶数");
            t.Sample(); // 結果:12偶数34偶数5

            // イベントハンドラの定義
            t.EventEven = () => Console.Write("X");
            t.Sample(); // 結果:12X34X5
        }
    }
}
