namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface IJsonSerializer <T>
    {
        string Serialize(T arg);
    }
}