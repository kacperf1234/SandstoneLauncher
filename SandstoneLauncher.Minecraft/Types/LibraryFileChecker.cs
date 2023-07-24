using System.IO;
using SandstoneLauncher.Minecraft.Interfaces;

namespace SandstoneLauncher.Minecraft.Types
{
    public class LibraryFileChecker : ILibraryFileChecker
    {
        public bool CheckFile(string path)
        {
            return File.Exists(path);
        }
    }
}