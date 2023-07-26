namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IMinecraftDirectory
    {
        string GetLibraries();

        string GetAssets();

        string GetVersions();

        string GetMinecraft();

        string GetLauncherProfiles();
    }
}