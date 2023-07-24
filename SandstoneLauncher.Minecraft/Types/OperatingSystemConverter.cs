using System;
using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Interfaces;

namespace SandstoneLauncher.Minecraft.Types
{
    public class OperatingSystemConverter : IOperatingSystemConverter
    {
        public string Convert(OS os)
        {
            return Enum.GetName(os.GetType(), os).ToLower();
        }
    }
}