using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class AssetsMultipliedFilter : IAssetsMultipliedFilter
    {
        public Dictionary<string, Asset> Filter(Dictionary<string, Asset> assets)
        {
            List<string> addedKeys = new List<string>();
            Dictionary<string, Asset> output = new Dictionary<string, Asset>();

            foreach (KeyValuePair<string, Asset> keyValuePair in assets)
            {
                //todo
                return null;
            }

            return null;
        }
    }
}