using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IFullVersionManifestDownloader
    {
        void Download(GameVersion version);
    }
}