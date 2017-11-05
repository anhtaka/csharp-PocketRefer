using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    // 基本クラス
    class Music
    {
        public virtual void Play()
        {
            Console.WriteLine("Music");
        }
    }
    // 派生クラス
    class Song : Music
    {
        public override void Play()  // オーバーライド
        {
            Console.WriteLine("Song");
        }
    }
    // 派生クラス
    class Symphony : Music
    {
        public override void Play()  // オーバーライド
        {
            Console.WriteLine("Symphony");
        }
    }
    // 派生クラス
    class NewMusic : Music
    {
        new public void Play()      // 隠蔽
        {
            Console.WriteLine("NewMusic");
        }
    }
    class ClassNew
    {
        static void Main()
        {
            Music m;
            m = new Song();         // Songクラスのインスタンスを代入
            m.Play();               // 結果:Song

            m = new Symphony();     // Symphonyクラスのインスタンスを代入
            m.Play();               // 結果:Symphony

            m = new NewMusic();     // NewMusicクラスのインスタンスを代入
            m.Play();               // 結果:Music

            var nm = new NewMusic();
            nm.Play();              // 結果:NewMusic
        }
    }
}
