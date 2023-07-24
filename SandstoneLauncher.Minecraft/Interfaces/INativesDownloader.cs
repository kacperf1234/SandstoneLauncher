using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface INativesDownloader
    {
        void Download(Library[] library, OS system, FullVersion version);

        void Download(Library library, OS system, FullVersion version);
    }
}