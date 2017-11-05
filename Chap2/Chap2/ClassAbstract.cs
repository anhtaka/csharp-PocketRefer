using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    // 抽象クラス
    abstract class Music3
    {
        public abstract void Play(); // 抽象メソッド
    }

    class ClassAbstract : Music3
    {
        public override void Play()
        {
            Console.WriteLine("Play");
        }

        static void Main()
        {
            new ClassAbstract().Play(); // 結果:Play
        }
    }
}
