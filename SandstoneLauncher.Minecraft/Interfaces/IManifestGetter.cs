using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IManifestGetter
    {
        VersionManifest GetManifest();
    }
}