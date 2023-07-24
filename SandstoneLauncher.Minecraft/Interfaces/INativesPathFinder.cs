using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface INativesPathFinder
    {
        string GetPath(DownloadArtifact art);

        string GetNativesDirectory(string versionid);
    }
}