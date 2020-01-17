namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface IStringComparer
    {
        bool Compare(string x1, string x2, bool ignoreCase = false);
    }
}