using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IVersionsFilter
    {
        IEnumerable<GameVersion> FilterVersions(VersionManifest manifest, VersionType type = VersionType.ALPHA);
    }
}