using System.IO;
using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class LibraryFileChecker : ILibraryFileChecker
    {
        public bool CheckFile(string path)
        {
            return File.Exists(path);
        }
    }
}