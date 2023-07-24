using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
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