using System;
using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class ApplicationData : IApplicationData
    {
        public string GetApplicationData()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SandstoneLauncher\\";
        }
    }
}