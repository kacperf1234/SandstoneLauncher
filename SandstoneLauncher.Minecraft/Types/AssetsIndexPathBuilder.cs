using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class AssetsIndexPathBuilder : IAssetsIndexPathBuilder
    {
        public IMinecraftDirectory Minecraft;

        public AssetsIndexPathBuilder(IMinecraftDirectory minecraft)
        {
            Minecraft = minecraft;
        }

        public string Build(string versionid)
        {
            return Minecraft.GetAssets() + "indexes\\" + versionid + ".json";
        }
    }
}