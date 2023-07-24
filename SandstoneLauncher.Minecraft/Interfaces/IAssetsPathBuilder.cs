namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IAssetsPathBuilder
    {
        string GetAbsolutePath(string hash);
    }
}