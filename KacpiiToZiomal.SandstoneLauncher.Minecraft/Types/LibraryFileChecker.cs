using System.IO;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class LibraryFileChecker : ILibraryFileChecker
    {
        public bool CheckFile(string path)
        {
            return File.Exists(path);
        }
    }
}