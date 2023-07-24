namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IFileListGenerator
    {
        string[] GetFiles(string dir, string searchPattern = "*", bool insideDirectories = false);
    }
}