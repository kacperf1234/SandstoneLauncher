using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface ILibrariesDownloader
    {
        void Download(Library library, OS sys);

        void Download(Library[] libraries, OS sys);
    }
}