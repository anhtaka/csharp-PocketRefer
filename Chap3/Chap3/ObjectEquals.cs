using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap3
{
    public class ObjectEquals
    {
        //Equalsメソッドをオーバーライドしたクラス
        public class NameInfo
        {
            public string LastName; //姓
            public string FirstName; //名

            public override bool Equals(object obj)
            {
                //対象オブジェクトがNameInfo型でなければfalse
                if (!(obj is NameInfo))
                    return false;

                NameInfo info = (NameInfo)obj;
                //姓名共に等しいかどうか
                return (this.FirstName.Equals(info.FirstName)
                    && this.LastName.Equals(info.LastName));
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }

        public static void Main(string[] args)
        {
            object a = new object();
            //bはaと同じ場所を参照する
            object b = a;
            Console.WriteLine("同じ場所を参照しているオブジェクトの比較:" + a.Equals(b));

            //person1,person2は同じ姓名。person3は異なる
            NameInfo person1 = new NameInfo() { FirstName = "Tsuyoshi", LastName = "Doi" };
            NameInfo person2 = new NameInfo() { FirstName = "Tsuyoshi", LastName = "Doi" };
            NameInfo person3 = new NameInfo() { FirstName = "Yoshihiro", LastName = "Yamada" };

            //オーバーライドしたEqualsメソッドにより、Trueとなる
            Console.WriteLine("姓名が等しい:" + person1.Equals(person2));

            //姓名が異なるのでFalseとなる
            Console.WriteLine("姓名が異なる:" + person1.Equals(person3));
            Console.ReadKey();
        }

    }
}
