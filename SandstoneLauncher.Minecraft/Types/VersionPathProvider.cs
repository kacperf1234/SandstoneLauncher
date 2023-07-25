using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class VersionPathProvider
    {
        public string ProvideVersionPath(string versionName)
        {
            return new MinecraftDirectory().GetVersions() + versionName;
        }
    }
}