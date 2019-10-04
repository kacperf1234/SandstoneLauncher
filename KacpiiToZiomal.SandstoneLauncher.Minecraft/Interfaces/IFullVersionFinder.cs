using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IFullVersionFinder
    {
        FullVersion Find(GameVersion version);
    }
}