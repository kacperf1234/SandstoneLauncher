﻿using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface INativesPathFinder
    {
        string GetPath(DownloadArtifact art);

        string GetNativesDirectory(string versionid);
    }
}