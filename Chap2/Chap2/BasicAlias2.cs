namespace Name1.Name2
{
    class Sample1
    {
    }
}

namespace NamesZ
{
    using MyName = Name1.Name2;

    // エイリアスと同名のクラス
    class MyName
    {
    }

    class Sample2
    {
        public void test()
        {
            // エイリアスMyNameの指定
            MyName::Sample1 a = new MyName::Sample1();
        }
    }
}
