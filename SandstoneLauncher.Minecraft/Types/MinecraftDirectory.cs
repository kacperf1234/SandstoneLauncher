using System;
using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    /// <summary>
    ///     paths must ended with \\.
    /// </summary>
    [SingleInstance]
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

        public string GetLauncherProfiles()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\launcher_profiles.json";
        }
    }
}