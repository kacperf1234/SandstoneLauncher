using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IGameFilesDownloader
    {
        void Download(GameVersion gameVersion, OS os);
    }
}