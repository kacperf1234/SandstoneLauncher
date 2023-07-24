using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IVersionTypeGetter
    {
        VersionType GetVersionType(GameVersion version);
    }
}