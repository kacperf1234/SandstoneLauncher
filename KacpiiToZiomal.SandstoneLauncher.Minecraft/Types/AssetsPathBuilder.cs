using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class AssetsPathBuilder : IAssetsPathBuilder
    {
        public IHashCombiner HashCombiner;
        public IMinecraftDirectory Minecraft;

        public AssetsPathBuilder(IMinecraftDirectory minecraft, IHashCombiner hashCombiner)
        {
            Minecraft = minecraft;
            HashCombiner = hashCombiner;
        }

        public string GetAbsolutePath(string hash)
        {
            /// name: icons/icon.png 
            /// hash: 3d9d87214 ...

            string path = Minecraft.GetAssets() + "objects\\"; // path + first letters + filename
            string firsthash = HashCombiner.GetFirstLetters(hash);

            return path + firsthash + "\\" + hash;
        }
    }
}