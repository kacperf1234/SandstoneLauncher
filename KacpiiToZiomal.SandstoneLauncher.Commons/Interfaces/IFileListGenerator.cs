namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface IFileListGenerator
    {
        string[] GetFiles(string dir, bool insideDirectories = false);
    }
}