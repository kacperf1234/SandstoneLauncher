using System.Collections.Generic;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Types
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