using System.IO;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class FileListGenerator : IFileListGenerator
    {
        public string[] GetFiles(string dir, bool insideDirectories = false)
        {
            return Directory.GetFiles(dir, "*",
                insideDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
        }
    }
}