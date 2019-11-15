namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface IJsonBuilder<T>
    {
        string Build(T arg);
    }
}