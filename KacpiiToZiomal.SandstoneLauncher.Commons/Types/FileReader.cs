using System.IO;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class FileReader : IFileReader
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }
    }
}