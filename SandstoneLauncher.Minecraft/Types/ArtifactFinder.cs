using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Types
{
    public class ArtifactFinder : IArtifactFinder
    {
        public DownloadArtifact GetDownloadArtifact(Library library, OS system)
        {
            if (system == OS.WINDOWS)
                return library.Download.Classifiers.Windows;

            if (system == OS.LINUX)
                return library.Download.Classifiers.Linux;

            return null;
        }
    }
}