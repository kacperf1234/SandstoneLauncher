using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IFullVersionManifestDownloader
    {
        void Download(GameVersion version);
    }
}