using System.Collections.Generic;
using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
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