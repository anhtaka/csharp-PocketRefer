using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class Music2
    {
        int songs = 0;　// デフォルトはprivate

        protected void Play()
        {
            Console.WriteLine(songs); // songsは参照可能
        }
        public void Play(int n)
        {
            Console.WriteLine(n);
        }
    }
    class ClassAccess
    {
        static void Main()
        {
            var c = new Music2();

            c.Play(1); // 結果：1

            // 以下はエラーとなる
            // c.song = 1;
            // c.Play();
        }
    }
}
