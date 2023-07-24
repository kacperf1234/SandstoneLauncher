using System.Linq;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
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