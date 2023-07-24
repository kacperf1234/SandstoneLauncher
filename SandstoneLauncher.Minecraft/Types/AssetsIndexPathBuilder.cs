using SandstoneLauncher.Minecraft.Interfaces;

namespace SandstoneLauncher.Minecraft.Types
{
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