using System;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    /// <summary>
    ///     paths must ended with \\.
    /// </summary>
    public class MinecraftDirectory : IMinecraftDirectory
    {
        public string GetAssets()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\assets\\";
        }

        public string GetLibraries()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\libraries\\";
        }

        public string GetMinecraft()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\";
        }

        public string GetVersions()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\versions\\";
        }
    }
}