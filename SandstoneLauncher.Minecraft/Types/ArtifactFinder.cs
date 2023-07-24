using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
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