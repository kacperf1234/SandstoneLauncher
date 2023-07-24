using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class NativesTemporaryPathFinder : INativesTemporaryPathFinder
    {
        public IFileNameExtractor Extractor;
        public IMinecraftDirectory Minecraft;

        public NativesTemporaryPathFinder(IFileNameExtractor ext, IMinecraftDirectory minecraft)
        {
            Extractor = ext;
            Minecraft = minecraft;
        }

        public string GetTemporaryPath(DownloadArtifact artifact)
        {
            return Minecraft.GetMinecraft() + "natives-jars\\" + Extractor.GetName(artifact.Path);
        }
    }
}