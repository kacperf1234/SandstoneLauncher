using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IArtifactFinder
    {
        DownloadArtifact GetDownloadArtifact(Library library, OS system);
    }
}