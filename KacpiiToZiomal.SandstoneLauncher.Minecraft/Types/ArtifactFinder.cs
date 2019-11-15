using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
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