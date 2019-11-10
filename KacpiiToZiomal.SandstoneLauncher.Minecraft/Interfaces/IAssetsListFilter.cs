using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IAssetsListFilter
    {
        IEnumerable<Asset> Filter(Assets assets);
    }
}