using System;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class OperatingSystemConverter : IOperatingSystemConverter
    {
        public string Convert(OS os)
        {
            return Enum.GetName(os.GetType(), os).ToLower();
        }
    }
}