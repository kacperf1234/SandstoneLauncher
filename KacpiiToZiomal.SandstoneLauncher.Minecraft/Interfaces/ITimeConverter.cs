using System;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface ITimeConverter
    {
        DateTime Convert(string obj);

        string Convert(DateTime obj);
    }
}