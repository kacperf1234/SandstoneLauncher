﻿using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class FullVersionManifestDownloader : IFullVersionManifestDownloader
    {
        public IHttpDownloader HttpDownloader;
        public IMinecraftDirectory MinecraftDirectory;

        public FullVersionManifestDownloader(IMinecraftDirectory minecraftDirectory, IHttpDownloader httpDownloader)
        {
            MinecraftDirectory = minecraftDirectory;
            HttpDownloader = httpDownloader;
        }

        public void Download(GameVersion version)
        {
            HttpDownloader.Download(version.Url,
                MinecraftDirectory.GetVersions() + version.Id + "\\" + version.Id + ".json");
        }
    }
}