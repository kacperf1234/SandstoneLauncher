using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class AssetsIndexCreator : IAssetsIndexCreator
    {
        public IFileCreator Creator;
        public IMinecraftDirectory Minecraft;

        public AssetsIndexCreator(IMinecraftDirectory minecraft, IFileCreator creator)
        {
            Minecraft = minecraft;
            Creator = creator;
        }

        public void Create(string json, string assetsid)
        {
            string destination = Minecraft.GetAssets() + "indexes\\" + assetsid + ".json";
            Creator.Create(destination, json);
        }
    }
}