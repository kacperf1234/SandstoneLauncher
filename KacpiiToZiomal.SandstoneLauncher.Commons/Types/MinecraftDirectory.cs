using System;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
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