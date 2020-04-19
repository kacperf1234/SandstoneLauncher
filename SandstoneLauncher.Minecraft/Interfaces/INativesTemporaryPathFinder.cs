using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface INativesTemporaryPathFinder
    {
        string GetTemporaryPath(DownloadArtifact artifact);
    }
}