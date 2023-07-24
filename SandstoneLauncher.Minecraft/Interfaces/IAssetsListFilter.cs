using System.Collections.Generic;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IAssetsListFilter
    {
        IEnumerable<Asset> Filter(Assets assets);
    }
}