using System.IO;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class FileListGenerator : IFileListGenerator
    {
        public string[] GetFiles(string dir, string searchPattern = "*", bool insideDirectories = false)
        {
            return Directory.GetFiles(dir, searchPattern,
                insideDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
        }
    }
}