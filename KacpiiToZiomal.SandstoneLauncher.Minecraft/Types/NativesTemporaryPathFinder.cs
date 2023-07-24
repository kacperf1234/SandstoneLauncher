using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
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