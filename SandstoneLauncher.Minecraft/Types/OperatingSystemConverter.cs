using System;
using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class OperatingSystemConverter : IOperatingSystemConverter
    {
        public string Convert(OS os)
        {
            return Enum.GetName(os.GetType(), os).ToLower();
        }
    }
}