using System.IO;
using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class FileListGenerator : IFileListGenerator
    {
        public string[] GetFiles(string dir, string searchPattern = "*", bool insideDirectories = false)
        {
            return Directory.GetFiles(dir, searchPattern,
                insideDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
        }
    }
}