using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IVersionGetter
    {
        IEnumerable<GameVersion> GetVersions(VersionManifest manifest, VersionType type = VersionType.ALPHA);
    }
}