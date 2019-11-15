using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IAssetsListFilter
    {
        IEnumerable<Asset> Filter(Assets assets);
    }
}