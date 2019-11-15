using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class NativesDirectory : INativesDirectory
    {
        public IDirectoryCreator Creator;
        public IMinecraftDirectory Dir;

        public NativesDirectory(IMinecraftDirectory dir, IDirectoryCreator creator)
        {
            Dir = dir;
            Creator = creator;
        }

        public string GetDirectory(string versionid)
        {
            string path = Dir.GetVersions() + versionid + $"\\{versionid}-natives\\";

            Creator.Create(path);
            return path;
        }
    }
}