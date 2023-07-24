using System;
using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class VersionTypeGetter : IVersionTypeGetter
    {
        public VersionType GetVersionType(GameVersion version)
        {
            string type = version.Type;

            if (type == "release" || type == "old_alpha") return VersionType.ALPHA;
            if (type == "snapshot" || type == "old_beta") return VersionType.BETA;

            throw new ArgumentException();
        }
    }
}