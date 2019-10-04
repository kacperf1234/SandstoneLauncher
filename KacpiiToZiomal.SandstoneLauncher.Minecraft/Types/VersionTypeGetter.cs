﻿using System;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
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