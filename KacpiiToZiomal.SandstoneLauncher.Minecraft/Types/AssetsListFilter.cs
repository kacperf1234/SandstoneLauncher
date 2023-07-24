using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class AssetsListFilter : IAssetsListFilter
    {
        public IEnumerable<Asset> Filter(Assets assets)
        {
            List<string> addedHashes = new List<string>();

            foreach (Asset asset in assets.Values)
                if (!addedHashes.Contains(asset.Hash))
                {
                    addedHashes.Add(asset.Hash);
                    yield return asset;
                }
        }
    }
}