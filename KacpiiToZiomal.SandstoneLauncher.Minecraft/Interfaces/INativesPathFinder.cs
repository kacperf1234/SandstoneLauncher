using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface INativesPathFinder
    {
        string GetPath(DownloadArtifact art);

        string GetNativesDirectory(string versionid);
    }
}