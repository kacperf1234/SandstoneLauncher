using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface ILibrariesDownloader
    {
        void Download(Library library, OS sys);

        void Download(Library[] libraries, OS sys);
    }
}