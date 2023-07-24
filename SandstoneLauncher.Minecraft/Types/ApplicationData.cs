using System;
using SandstoneLauncher.Minecraft.Interfaces;

namespace SandstoneLauncher.Minecraft.Types
{
    public class ApplicationData : IApplicationData
    {
        public string GetApplicationData()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SandstoneLauncher\\";
        }
    }
}