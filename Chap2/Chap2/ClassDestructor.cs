using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class Squar4
    {
        // コンストラクタ
        public Squar4()
        {
            Console.WriteLine("コンストラクタ");
        }

        // デストラクタ
        ~Squar4()
        {
            Console.WriteLine("デストラクタ");
        }
    }
    class ClassDestructor
    {
        static void Main(string[] args)
        {
            Squar4 tmp = new Squar4();
        }
    }
}
