using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap2
{
    class ClassOperator
    {
        public string msg;
        public ClassOperator(string msg) { this.msg = msg;}

        // *演算子のオーバーロード
        public static ClassOperator operator *(ClassOperator c1, int n)
        {
            return new ClassOperator(c1.msg + "×" + n);
        }
        static void Main(string[] args)
        {

            ClassOperator tmp = new ClassOperator("sample") * 5;
            Console.WriteLine(tmp.msg);    // 結果：sample×5
        }
    }
}
