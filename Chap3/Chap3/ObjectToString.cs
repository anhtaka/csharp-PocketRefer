using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    public class ObjectToString
    {
        public class NameInfo
        {
            public string LastName; //姓
            public string FirstName; //名

            //ToStringメソッドのオーバーライド
            public override string ToString()
            {
                return LastName + " " + FirstName;
            }
        }

        public static void Main(string[] args)
        {
            object a = new object();
            Console.WriteLine("Object型のToString:" + a.ToString());
            int i = 64;
            Console.WriteLine("Int32型のToString:" + i.ToString());
            NameInfo person1 = new NameInfo()
            { FirstName = "Tsuyoshi", LastName = "Doi" };
            Console.WriteLine("NameInfo型のToString:" + person1.ToString());
            Console.ReadKey();
        }

    }
}
