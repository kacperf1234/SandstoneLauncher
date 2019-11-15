using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class VersionsFilter : IVersionsFilter
    {
        public IVersionTypeGetter TypeGetter;

        public VersionsFilter(IVersionTypeGetter typeGetter)
        {
            TypeGetter = typeGetter;
        }

        public IEnumerable<GameVersion> FilterVersions(VersionManifest manifest, VersionType type = VersionType.ALPHA)
        {
            foreach (GameVersion v in manifest.Versions)
                if (TypeGetter.GetVersionType(v) == type)
                    yield return v;
        }
    }
}