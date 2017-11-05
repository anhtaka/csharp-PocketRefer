namespace NameX.NameY
{
    class Sample
    {
        public void method1()
        {
        }
    }
}


namespace NamesZ
{
    using MyClass = NameX.NameY.Sample;
    // 以降MyClassのみで、NameX.NameY.Sampleが参照可能
}
