using System.IO;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
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