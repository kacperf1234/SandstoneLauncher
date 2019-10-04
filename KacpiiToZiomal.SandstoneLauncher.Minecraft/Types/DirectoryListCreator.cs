using System.IO;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class DirectoryListCreator : IDirectoryListCreator
    {
        public string[] GetDirectories(string path)
        {
            try
            {
                return Directory.GetDirectories(path);
            }

            catch (DirectoryNotFoundException)
            {
                return new string[0];
            }
        }
    }
}