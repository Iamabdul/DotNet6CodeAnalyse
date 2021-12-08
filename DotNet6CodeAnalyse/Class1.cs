namespace DotNet6CodeAnalyse
{
    public class DoSomething
    {
        public int DoSomethingDependantOn(bool thisBool)
            => thisBool ? 1 : 0;
    }
}