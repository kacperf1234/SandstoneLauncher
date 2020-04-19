using Ionic.Zip;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class JarFileExtractor : IJarFileExtractor
    {
        public void ExtractAll(string filename, string destination)
        {
            ZipFile ZipFile = new ZipFile(filename);
            ZipFile.ExtractAll(destination, ExtractExistingFileAction.OverwriteSilently);
        }
    }
}