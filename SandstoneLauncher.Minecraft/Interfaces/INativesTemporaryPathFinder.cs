using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface INativesTemporaryPathFinder
    {
        string GetTemporaryPath(DownloadArtifact artifact);
    }
}