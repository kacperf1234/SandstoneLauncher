using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface INativesDownloader
    {
        void Download(Library[] library, OS system, FullVersion version);

        void Download(Library library, OS system, FullVersion version);
    }
}