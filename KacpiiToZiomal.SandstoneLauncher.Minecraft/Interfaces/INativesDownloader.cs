using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface INativesDownloader
    {
        void Download(Library[] library, OS system, FullVersion version);

        void Download(Library library, OS system, FullVersion version);
    }
}