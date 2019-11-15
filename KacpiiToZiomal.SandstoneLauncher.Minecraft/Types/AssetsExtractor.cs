using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class AssetsExtractor : IAssetsExtractor
    {
        public Asset Get(Assets assets, string name)
        {
            string key = assets.Keys
                .Where(x => x.Length == name.Length)
                .Where(x => x == name)
                .First();

            return assets[key];
        }
    }
}