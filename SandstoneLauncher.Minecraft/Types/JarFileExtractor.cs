using Ionic.Zip;
using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class JarFileExtractor : IJarFileExtractor
    {
        public void ExtractAll(string filename, string destination)
        {
            ZipFile ZipFile = new ZipFile(filename);
            ZipFile.ExtractAll(destination, ExtractExistingFileAction.OverwriteSilently);
        }
    }
}