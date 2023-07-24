using System.Collections.Generic;
using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IVersionsFilter
    {
        IEnumerable<GameVersion> FilterVersions(VersionManifest manifest, VersionType type = VersionType.ALPHA);
    }
}