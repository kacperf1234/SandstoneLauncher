using System.IO;
using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
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