using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IVersionsFilter
    {
        IEnumerable<GameVersion> FilterVersions(VersionManifest manifest, VersionType type = VersionType.ALPHA);
    }
}