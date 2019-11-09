using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IAssetsMultipliedFilter
    {
        Dictionary<string, Asset> Filter(Dictionary<string, Asset> assets);
    }
}