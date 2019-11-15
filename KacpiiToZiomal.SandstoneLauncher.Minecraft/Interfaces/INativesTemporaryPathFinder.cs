using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface INativesTemporaryPathFinder
    {
        string GetTemporaryPath(DownloadArtifact artifact);
    }
}