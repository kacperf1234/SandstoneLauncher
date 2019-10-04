using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface ILibrariesDownloader
    {
        void Download(Library library, OS sys);

        void Download(Library[] libraries, OS sys);
    }
}